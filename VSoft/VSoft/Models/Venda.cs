using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public Dono Dono { get; set; }
        public int IdDono { get; set; }

        public Funcionario Funcionario { get; set; }
        public int IdFuncionario { get; set; }
    }
}