using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Receituario
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string UNMedida { get; set; }
        public int Peso { get; set; }
        public string ReceitaTexto { get; set; }

        public HistoricoClinico HistoricoClinico { get; set; }
        public int IdHistoricoClinico { get; set; }

        public HistoricoMedicamento HistoricoMedicamento { get; set; }
        public int IdHistoricoMedicamento { get; set; }
    }
}