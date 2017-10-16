using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Diagnostico_Historico
    {
        public int Id { get; set; }

        public HistoricoClinico HistoricoClinico { get; set; }
        public int IdHistoricoClinico { get; set; }

        public Diagnostico Diagnostico { get; set; }
        public int IdDiagnostico { get; set; }
    }
}