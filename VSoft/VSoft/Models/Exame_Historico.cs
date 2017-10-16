using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Exame_Historico
    {
        public int Id { get; set; }

        public Exame Exame { get; set; }
        public int IdExame { get; set; }

        public HistoricoClinico HistoricoClinico { get; set; }
        public int IdHitoricoClinico { get; set; }
    }
}