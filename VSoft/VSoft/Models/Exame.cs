
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string UNMedida { get; set; }
        public int Peso { get; set; }

        public int TipoExameId { get; set; }
        public TipoExame TipoExame { get; set; }
    }
}