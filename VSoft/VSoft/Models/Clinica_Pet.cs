using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Clinica_Pet
    {
        public int Clinica_PetId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public long CNPJ { get; set; }
    }
}