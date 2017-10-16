using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public long RG { get; set; }
        public long CPF { get; set; }
        public long Celular { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public long CEP { get; set; }

        public decimal Salairo { get; set; }
        public string Funcao { get; set; }
        public Clinica_Pet Clinica_Pet { get; set; }
        public int IdClinica { get; set; }
    }
}