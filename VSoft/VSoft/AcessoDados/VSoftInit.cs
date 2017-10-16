using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VSoft.Models;

namespace VSoft.AcessoDados
{
    public class VSoftInit : CreateDatabaseIfNotExists<VSoftContexto>
    {
        protected override void Seed(VSoftContexto contexto)
        {

            #region ESTADOS
            List<Estado> estados = new List<Estado>()
            {
                new Estado() { NMEstado = "AC"},
                new Estado() { NMEstado = "AL"},
                new Estado() { NMEstado = "AP"},
                new Estado() { NMEstado = "AM"},
                new Estado() { NMEstado = "BA"},
                new Estado() { NMEstado = "CE"},
                new Estado() { NMEstado = "DF"},
                new Estado() { NMEstado = "ES"},
                new Estado() { NMEstado = "GO"},
                new Estado() { NMEstado = "MA"},
                new Estado() { NMEstado = "MS"},
                new Estado() { NMEstado = "PA"},
                new Estado() { NMEstado = "PB"},
                new Estado() { NMEstado = "PE"},
                new Estado() { NMEstado = "PI"},
                new Estado() { NMEstado = "PR"},
                new Estado() { NMEstado = "RJ"},
                new Estado() { NMEstado = "RN"},
                new Estado() { NMEstado = "RO"},
                new Estado() { NMEstado = "RR"},
                new Estado() { NMEstado = "SC"},
                new Estado() { NMEstado = "SP"},
                new Estado() { NMEstado = "SE"},
                new Estado() { NMEstado = "TO"}

            };
            estados.ForEach(e => contexto.Estados.Add(e));
            #endregion

            #region CIDADES
            List<Cidade> cidades = new List<Cidade>()
            {
                new Cidade() {  NMCidade= "Curitiba",
                                Estado = estados.FirstOrDefault(e => e.NMEstado == "PR")
                },

                new Cidade() {  NMCidade= "Maringá",
                                Estado = estados.FirstOrDefault(e => e.NMEstado == "PR")
                }
            };
            cidades.ForEach(c => contexto.Cidades.Add(c));
            #endregion

            #region ESPECIES
            List<Especie> especies = new List<Especie>
            {
                new Especie() {Descricao = "Ave"},
                new Especie() {Descricao = "Bovina"},
                new Especie() {Descricao = "Caprino"},
                new Especie() {Descricao = "Coelho"},
                new Especie() {Descricao = "Equino"},
                new Especie() {Descricao = "Felino"},
                new Especie() {Descricao = "Ovino"},
                new Especie() {Descricao = "Peixe"},
                new Especie() {Descricao = "Réptil"},
                new Especie() {Descricao = "Suina"}
            };
            especies.ForEach(e => contexto.Especies.Add(e));

            #endregion

            #region RACAS
            List<Raca> racas = new List<Raca>()
            {
                #region Ave
                new Raca() { Descricao = "Andorinha",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },

                new Raca() { Descricao = "Bandeirinha",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },

                new Raca() { Descricao = "Coruja",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },

                new Raca() { Descricao = "Degolado",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },

                new Raca() { Descricao = "Quero quero",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },

                new Raca() { Descricao = "Gavião",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ave")
                },
                #endregion

                #region Bovina                 
                new Raca() { Descricao = "Angus",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Bovina")
                },

                new Raca() { Descricao = "Caracu",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Bovina")
                },

                new Raca() { Descricao = "Nelore",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Bovina")
                },
	            #endregion

                #region Canina
                new Raca() {Descricao = "Akita",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Basset Hound",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Cocker Spaniel Inglês",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Golden Retriever",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Maltês",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Pastor Alemão",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },

                new Raca() {Descricao = "Sem Raça Definida",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Canina")
                },
                #endregion

                #region Caprino
                new Raca() {Descricao = "Repartida",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Caprino")
                },

                new Raca() {Descricao = "Canindé",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Caprino")
                },

                new Raca() {Descricao = "Boer",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Caprino")
                },                
	            #endregion

                #region Coelho
                new Raca() {Descricao = "Holandês",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Coelho")
                },

                new Raca() {Descricao = "Dwarf Hotot",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Coelho")
                },

                new Raca() {Descricao = "Mini lop",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Coelho")
                },

                new Raca() {Descricao = "Polish",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Coelho")
                },

                new Raca() {Descricao = "Lion",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Coelho")
                }, 
	            #endregion 
                
                #region Equino
                new Raca() {Descricao = "American Saddlebred",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Equino")
                },

                new Raca() {Descricao = "Finlandês",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Equino")
                },

                new Raca() {Descricao = "Pônei",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Equino")
                },

                new Raca() {Descricao = "Puro Sangue Lusitano",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Equino")
                },

                new Raca() {Descricao = "Shire",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Equino")
                },
                #endregion

                #region Felino
                 new Raca() {Descricao = "Abissínio",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Angorá",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Egyptian Mau",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Exótico",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Maine Coon",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Persa",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },

                 new Raca() {Descricao = "Scottish Fold",
                            Especie = especies.FirstOrDefault(e => e.Descricao == "Felino")
                },               
                #endregion

                #region Ovino
                 new Raca() {Descricao = "Dorper",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ovino")
                 },

                 new Raca() {Descricao = "Merino",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ovino")
                 },

                 new Raca() {Descricao = "Ryeland",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ovino")
                 },

                 new Raca() {Descricao = "Texel",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Ovino")
                 },
	            #endregion
                
                #region Peixe
                 new Raca() {Descricao = "Abelhinha",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },

                 new Raca() {Descricao = "Baiacu",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },

                 new Raca() {Descricao = "Dojô",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },

                 new Raca() {Descricao = "Neon",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },

                 new Raca() {Descricao = "Peixe-palhaço",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },

                 new Raca() {Descricao = "Tubarão",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Peixe")
                 },
	            #endregion

                #region Reptil
                 new Raca() {Descricao = "Anole Verde",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Réptil")
                 },

                 new Raca() {Descricao = "Boicora",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Réptil")
                 },

                 new Raca() {Descricao = "Cobra-de-vidro",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Réptil")
                 },

                 new Raca() {Descricao = "Jararaca-verde",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Réptil")
                 },

                 new Raca() {Descricao = "Lagarto aranha",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Réptil")
                 },
	            #endregion

                #region Suina
                 new Raca() {Descricao = "Berkshire",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Suina")
                 },

                 new Raca() {Descricao = "British Lop",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Suina")
                 },

                 new Raca() {Descricao = "Cantonense",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Suina")
                 },

                 new Raca() {Descricao = "Duroc",
                             Especie = especies.FirstOrDefault(e => e.Descricao == "Suina")
                 }
                 #endregion
            };
            racas.ForEach(r => contexto.Racas.Add(r));
            #endregion

            #region SEXOS
            List<Sexo> sexos = new List<Sexo>()
            {
                new Sexo(){ Descricao= "Macho"},
                new Sexo(){ Descricao= "Femêa"},
                new Sexo(){ Descricao= "Macho - Castrado"},
                new Sexo(){ Descricao= "Femêa - Esterelizada"},
                new Sexo(){ Descricao= "Indeterminado"}
            };
            sexos.ForEach(s => contexto.Sexos.Add(s));
            #endregion

            #region PORTES
            List<Porte> portes = new List<Porte>()
            {
                new Porte() {Descricao = "Pequeno"},
                new Porte() {Descricao = "Médio"},
                new Porte() {Descricao = "Grande"},
                new Porte() {Descricao = "Gigante"}
            };
            portes.ForEach(p => contexto.Portes.Add(p));
            #endregion

            #region DONOS
            List<Dono> donos = new List<Dono>()
            {
                new Dono() {
                             Email = "fran8ctba@hotmail.com",
                             Senha = "123456",
                             Nome = "Francieli Ferreira",
                             Sexo = 'F',
                             DtNascimento = new DateTime(1999,11,08),
                             RG = 103171261,
                             CPF = 11908805986,
                             Celular = 41984568688,
                             Telefone = 4132691901,
                             CEP = 81220450,
                             Endereco = "Antônio Paulino Teixeira de Freitas - 267",
                             Bairro = "Campo Comprido",
                             Cidade = cidades.FirstOrDefault(c => c.NMCidade == "Curitiba")
                },

                new Dono() {
                             Email = "camiscoltinho@hotmail.com",
                             Senha = "123456789",
                             Nome = "Camila Colto",
                             Sexo = 'F',
                             DtNascimento = new DateTime(1993,03,02),
                             RG = 126152359,
                             CPF = 11654423658,
                             Celular = 41985626456,
                             Telefone = 4132659832,
                             CEP = 36542983,
                             Endereco = "Pedro Dibas - 556",
                             Bairro = "NaoSei",
                             Cidade = cidades.FirstOrDefault(c => c.NMCidade == "Maringá")
                }

            };
            donos.ForEach(d => contexto.Donos.Add(d));
            #endregion

            #region ANIMAIS
            List<Animal> animais = new List<Animal>()
            {
                new Animal{
                            Nome = "Dog",
                            Idade = 7,
                            Anilha= 000111,
                            ConsumoRacao = 380,
                            Pelagem = "Branca",
                            Pedigree = true,
                            Dono = donos.FirstOrDefault(d => d.Nome == "Francieli Ferreira"),
                            Sexo = sexos.FirstOrDefault(s => s.Descricao == "Macho - Castrado"),
                            Raca = racas.FirstOrDefault(r => r.Descricao == "Akita" ),
                            Porte = portes .FirstOrDefault(p => p.Descricao == "Médio")
                },

                new Animal{
                            Nome = "Totó",
                            Idade = 3,
                            Anilha= 000222,
                            ConsumoRacao = 17,
                            Pedigree = true,
                            Pelagem = "Mesclado",
                            Dono = donos.FirstOrDefault(d => d.Nome == "Camila Colto"),
                            Sexo = sexos.FirstOrDefault(s => s.Descricao == "Femêa"),
                            Raca = racas.FirstOrDefault(r => r.Descricao == "Persa" ),
                            Porte = portes .FirstOrDefault(p => p.Descricao == "Médio")
                }
            };
            animais.ForEach(a => contexto.Animais.Add(a));
            #endregion
        }
    }
}