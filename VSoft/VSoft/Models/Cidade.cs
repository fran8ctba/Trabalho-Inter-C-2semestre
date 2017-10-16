using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string NMCidade { get; set; }

        public Estado Estado { get; set; }
        public int EstadoId { get; set; }
    }
}