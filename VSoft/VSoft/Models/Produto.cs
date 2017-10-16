using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models  
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public decimal ValorCusto { get; set; }
        public int Porcenteagem { get; set; }
        public DateTime DtFabricacao { get; set; }
        public DateTime DtVencimento { get; set; }
    }
}