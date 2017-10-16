
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class HistoricoMedicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtAplicacao { get; set; }
        public int QtDiasProxima { get; set; }
        public int Doses { get; set; }
        public string Tipo { get; set; }

        public Animal Animal { get; set; }
        public int IdAnimal { get; set; }

        public Produto Produto { get; set; }
        public int IdProduto { get; set; }
    }
}