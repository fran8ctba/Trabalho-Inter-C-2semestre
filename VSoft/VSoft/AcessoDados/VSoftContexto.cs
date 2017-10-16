using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VSoft.Models;

namespace VSoft.AcessoDados
{
    public class VSoftContexto : DbContext

    {
        public VSoftContexto() : base("Asp_Net_MVC_CS") { }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Clinica_Pet> Clinicas_Pets { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Diagnostico_Historico> Diagnosticos_Historico { get; set; }
        public DbSet<Dono> Donos { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Exame_Historico> Exames_Historico { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<HistoricoClinico> HistoricosClinicos { get; set; }
        public DbSet<HistoricoMedicamento> HistoricosMedicamentos { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produtos_Venda> ProdutosVendas { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Receituario> Receituarios { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoExame> TiposExames { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}