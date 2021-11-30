using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class FormasPagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FormasPagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/createformas
        [HttpPost]
        [Route("createformas")]
        public IActionResult CreateFormas()
        {
            _context.FormasPagamentos.AddRange(new FormasPagamento[]
                {
                    new FormasPagamento { FormasPagamentoId = 1, Nome = "Cartão", Dados = "1123 5698 2589 3658" },
                    new FormasPagamento { FormasPagamentoId = 2, Nome = "Boleto", Dados = "teste" },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Formas de pagamanto adicionadas com sucesso!" });
        }
        //GET: api/formapagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormasPagamentos.ToList());
    }
}