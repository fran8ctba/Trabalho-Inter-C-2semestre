using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Anilha { get; set; }
        public decimal ConsumoRacao { get; set; }
        public string Pelagem { get; set; }
        public Boolean Pedigree { get; set; }

        public Dono Dono { get; set; }
        public int DonoId { get; set; }

        public HistoricoClinico HistoricoClinico { get; set; }
        public int HistoricoClinicoId { get; set; }

        public Sexo Sexo { get; set; }
        public int SexoId { get; set; }

        public Raca Raca { get; set; }
        public int RacaId { get; set; }

        public Porte Porte { get; set; }
        public int PorteId { get; set; }
    }
}