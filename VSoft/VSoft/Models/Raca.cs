
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Raca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int EspecieId { get; set; }
        public Especie Especie { get; set; }
    }
}