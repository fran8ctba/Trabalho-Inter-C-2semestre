using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Dono
    {
        public int DonoId { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Data Nascimento")]
        public DateTime DtNascimento { get; set; }
        public long RG { get; set; }
        public long CPF { get; set; }
        public long Celular { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public long CEP { get; set; }

        public Cidade Cidade { get; set; }
        public int CidadeId { get; set; }
    }
}