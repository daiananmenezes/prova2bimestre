using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Venda
    {
        public Venda() => CriadoEm = DateTime.Now;
        public int VendaId { get; set; }
        public string Cliente { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public FormasPagamento FormasPagamento { get; set; }
        public int FormasPagamentoId { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}