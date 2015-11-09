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
            IGitClient client = new GitClient();

            var resultados = await client.ObterRepositoriosUsuario();

            Assert.IsNotNull(resultados);
            Assert.AreNotEqual(0, resultados.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObterRepositoriosUsuarioException))]
        public async void ObterRepositoriosUsuarioError_Test()
        {
            GitRepositoriosConfig.NomeUsuario = "asasasasasassassassa";
            IGitClient client = new GitClient();
            
            var resultados = await client.ObterRepositoriosUsuario();            
        }

        [TestMethod]
        public async void ObterRepositoriosPorNomeSuccess_Test()
        {
            IGitClient client = new GitClient();

            var resultados = await client.ObterRepositoriosPorNome("Way2Test2");

            Assert.IsNotNull(resultados);
            Assert.AreEqual(1, resultados.Items.Count);
            Assert.AreEqual(resultados.Items[0].Owner.Login, "maflorido");
        }

        [TestMethod]
        [ExpectedException(typeof(ObterPorNomeException))]
        public async void ObterRepositoriosPorNomeErro_Test()
        {
            IGitClient client = new GitClient();

            var resultados = await client.ObterRepositoriosPorNome("Way2Test2asasasasasasa");
            
        }

        [TestMethod]
        public async void ObterRepositorioPorNomeSuccess_Test()
        {
            IGitClient client = new GitClient();

            var resultado = await client.ObterRepositorioPorNome("Way2Test2");

            Assert.IsNotNull(resultado);
            Assert.AreEqual(resultado.Items[0].Owner.Login, "maflorido");
        }

        [TestMethod]
        [ExpectedException(typeof(ObterPorNomeException))]
        public async void ObterRepositorioPorNomeErro_Test()
        {
            IGitClient client = new GitClient();

            var resultado = await client.ObterRepositorioPorNome("Way2Test2asasasasasasa");

        }

        [TestMethod]
        public async void ObterColaboradoresRepositorioSuccess_Test()
        {
            IGitClient client = new GitClient();

            var resultado = await client.ObterColaboradoresRepositorio("maflorido", "Way2Test2");

            Assert.IsNotNull(resultado);
            Assert.AreEqual(resultado[0].Login, "maflorido");
            Assert.AreEqual(1, resultado.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObterColaboradoresException))]
        public async void ObterColaboradoresRepositorioErro_Test()
        {
            IGitClient client = new GitClient();

            var resultado = await client.ObterColaboradoresRepositorio("maflorido", "Way2Test2asasasasasasa");

        }
    }
}
