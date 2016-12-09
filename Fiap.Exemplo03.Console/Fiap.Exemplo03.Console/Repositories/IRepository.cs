using Fiap.Exemplo03.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Fiap.Exemplo03.Console.Repositories
{
    public interface IRepository
    {
        //IEnumerable<AlunoDTO> Listar();

        void Cadastrar();
    }
}
