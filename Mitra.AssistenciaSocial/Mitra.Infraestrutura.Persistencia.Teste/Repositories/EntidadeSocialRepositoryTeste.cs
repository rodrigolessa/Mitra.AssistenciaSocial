using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mitra.Dominio.Entities;
using Mitra.Infraestrutura.Persistencia.UnitOfWork;

namespace Mitra.Infraestrutura.Persistencia.Teste.Repositories
{
    [TestFixture]
    public class EntidadeSocialRepositoryTeste
    {
        private MitraContext unit;

        [SetUp]
        public void Initializer()
        {
            unit = new MitraContext();
        }

        #region Testes Positivos

        //CPA COMUNIDADE PORTO ALEGRE
        //AACD ASSOCIAÇÃO DE ASSISTÊNCIA À CRIANÇA DEFICIENTE
        //ABRAÇAÍ
        //ABRIGO SAMARITANO
        //ASSOCIAÇÃO BENEFICENTE Social
        //AÇÃO SOCIAL DE FÉ

        [Test]
        public void CriarEntidadeSocial()
        {
            var _QUERY_DELETE_ENTIDADE = "DELETE FROM Mitra.AssistenciaSocial.EntidadeSocial WHERE Nome LIKE 'CPA COMUNIDADE PORTO ALEGRE';";
            unit.Database.ExecuteSqlCommand(_QUERY_DELETE_ENTIDADE);

            var entidade = new EntidadeSocial()
            {
                Nome = "CPA COMUNIDADE PORTO ALEGRE",
                Endereco = "Porto Alegre",
                Telefone = "2879-2658",
                CNPJ = "30.147.995/0025"
            };

            unit.EntidadeSocials.Add(entidade);
            var linhasAlteradas = unit.SaveChanges();

            Assert.AreEqual(1, linhasAlteradas, "Linhas de registro do banco afetadas ao salvar uma nova entidade!");
        }

        [Test]
        public void ListarEntidadeSocial()
        {
        }

        [Test]
        public void ExcluirEntidadeSocial()
        {
            var NomeEntidade = "ABRIGO SAMARITANO";
            var CNPJEntidade = "30.147.995/0025";
            var _QUERY_INSERT_ENTIDADE = "INSERT INTO Mitra.AssistenciaSocial.EntidadeSocial (Nome, Endereco, Telefone, CNPJ) VALUES ('" + NomeEntidade + "', 'Rio de Janeiro, São Gonçalo', '2879-2658', '" + CNPJEntidade + "');";
            unit.Database.ExecuteSqlCommand(_QUERY_INSERT_ENTIDADE);

            var entidade = unit.EntidadeSocials.Where(x => x.Nome.Contains(NomeEntidade)).FirstOrDefault();

            Assert.AreEqual(CNPJEntidade, entidade.CNPJ, "CNPJ da entidade localizada!");

            unit.EntidadeSocials.Remove(entidade);
            var linhasAlteradas = unit.SaveChanges();

            Assert.AreEqual(1, linhasAlteradas, "Linhas de registro do banco afetadas ao excluir a entidade!");
        }

        #endregion
    }
}
