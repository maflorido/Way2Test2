using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitApi.Web.GitRepositorios;
using GitApi.Web.Exceptions;

namespace GitApi.Tests.GitRepositorios
{
    [TestClass]
    public class GitClientTest
    {
        [TestMethod]
        public async void ObterRepositoriosUsuarioSuccess_Test()
        {
            GitClient client = new GitClient();

            var resultados = await client.ObterRepositoriosUsuario();

            Assert.IsNotNull(resultados);
            Assert.AreNotEqual(0, resultados.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObterRepositoriosUsuarioException))]
        public async void ObterRepositoriosUsuarioError_Test()
        {
            GitRepositoriosConfig.NomeUsuario = "asasasasasassassassa";
            GitClient client = new GitClient();
            
            var resultados = await client.ObterRepositoriosUsuario();            
        }
    }
}
