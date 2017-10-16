using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public string UnMedida { get; set; }
        public decimal  Peso { get; set; }
        public string DiagTexto { get; set; }

    }
}