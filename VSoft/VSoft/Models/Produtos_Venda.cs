using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSoft.Models
{
    public class Produtos_Venda
    {
        public int Id { get; set; }
        public int QuanVendida { get; set; }

        public Produto Produto { get; set; }
        public int IdProduto { get; set; }

        public Venda Venda { get; set; }
        public int IdVenda { get; set; }
    }
}