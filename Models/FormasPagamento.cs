using System;

namespace API.Models
{
    public class FormasPagamento
    {
        public FormasPagamento() => CriadoEm = DateTime.Now;

        public int FormasPagamentoId { get; set; }
        public string Nome  { get; set; }
        public string Dados { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}