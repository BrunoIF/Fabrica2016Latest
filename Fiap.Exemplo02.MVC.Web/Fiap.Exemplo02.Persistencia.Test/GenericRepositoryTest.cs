using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.Exemplo02.Persistencia.Repositories;
using Fiap.Exemplo02.Dominio.Models;

namespace Fiap.Exemplo02.Persistencia.Test
{
    /// <summary>
    /// Summary description for GenericRepositoryTest
    /// </summary>
    [TestClass]
    public class GenericRepositoryTest
    {
        private GenericRepository<Aluno> _repository;
        private PortalContext _context;

        [TestInitialize]
        public void Inicializacao()
        {
            // Inicializar os objetos
            _context = new PortalContext();
            _repository = new GenericRepository<Aluno>(_context);
        }

        [TestMethod]
       public void Cadastrar_Ok()
        {
            // Instanciar o aluno
            var aluno = new Aluno()
            {
                Nome = "Teste",
                Bolsa = false,
                DataNascimento = DateTime.Now,
                Desconto = 10,
                Grupo = new Grupo() { Nome = "Grupo Teste" }
            };
            // Cadastro o aluno
            _repository.Cadastrar(aluno);
            _context.SaveChanges();
            // 
        }
    }
}
