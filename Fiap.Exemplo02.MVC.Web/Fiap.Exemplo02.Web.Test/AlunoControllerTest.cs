using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.Exemplo02.MVC.Web.Controllers;
using Fiap.Exemplo02.MVC.Web.ViewModels;
using System.Web.Mvc;

namespace Fiap.Exemplo02.Web.Test
{
    [TestClass]
    public class AlunoControllerTest
    {

        private AlunoController controller = new AlunoController();

        [TestMethod]
        public void Cadastrar_Get()
        {

            var resultado = (ViewResult)controller.Cadastrar("");
            Assert.IsNotNull(resultado);
            Assert.AreEqual("", resultado.ViewName);
        }

        [TestMethod]
        public void Cadastrar_Post()
        {
            var aluno = new AlunoViewModel()
            {
                Nome = "Teste",
                Bolsa = false,
                DataNascimento = DateTime.Now,
                Desconto = 10
            };
            var resultado = (ViewResult)controller.Cadastrar(aluno);
            Assert.IsNotNull(resultado);

            var modelValido = resultado.ViewData.ModelState.IsValid;
            Assert.IsFalse(modelValido);

            var chaveErros = resultado.ViewData.ModelState.Keys;
            foreach (var item in chaveErros)
            {
                Assert.AreEqual("Nome", item);
            }
        }
    }
}
