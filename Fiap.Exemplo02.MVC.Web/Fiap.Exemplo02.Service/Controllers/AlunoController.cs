using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fiap.Exemplo02.Persistencia.UnitsOfWork;
using Fiap.Exemplo02.Dominio.Models;
using System.Web.Http.Cors;

namespace Fiap.Exemplo02.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AlunoController : ApiController
    {
        private UnitOfWork _unit = new UnitOfWork();

        //GET api/aluno

        public ICollection<Aluno> Get()
        {
            return _unit.AlunoRepository.Listar();
        }

        // Get api/aluno/(id)
        public Aluno Get(int id)
        {
            return _unit.AlunoRepository.BuscarPorId(id);
        }

        // POST / Cadastrar

        public IHttpActionResult Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _unit.AlunoRepository.Cadastrar(aluno);
                _unit.Salvar();
                var uri = Url.Link("DefaultApi", new { id = aluno.Id });
                return Created<Aluno>(new Uri(uri), aluno);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT / Atualizar
        public IHttpActionResult Put(int id, Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno.Id = id;
                _unit.AlunoRepository.Alterar(aluno);
                _unit.Salvar();
                return Ok(aluno);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        // DELETE / Remover
        public void Delete(int id)
        {
            _unit.AlunoRepository.Remover(id);
            _unit.Salvar();            
        }

    }
}
