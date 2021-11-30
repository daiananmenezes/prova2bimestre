using System;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

        //GET: api/venda/list
        //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
        [HttpGet]
        [Route("list")]
        public IActionResult List() =>
            Ok(_context.Vendas
            .Include(p => p.FormasPagamento)
            .ToList());

        // POST: api/produto/create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] Venda venda)
        {
            venda.FormasPagamento = _context.FormasPagamentos.Find(venda.FormasPagamentoId);
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();
            return Created("", venda);
        }
    }
}