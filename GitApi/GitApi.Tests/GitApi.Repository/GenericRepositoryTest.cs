using GitApi.Domain.Entities;
using GitApi.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GitApi.Tests.GitApi.Repository
{
    [TestClass]
    public class GenericRepositoryTest
    {
        [TestMethod]
        public void IncluirSuccess_Test()
        {
            var mock = new Mock<GenericRepository<Favoritos>>();

            mock.Setup(x => x.Incluir(new Favoritos() { Id = 1, IdRepositorioGit = 1, NomeRepositorio = "teste" }));



        }
    }
}
