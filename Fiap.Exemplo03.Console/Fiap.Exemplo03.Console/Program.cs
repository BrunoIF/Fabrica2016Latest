using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Exemplo03.Console.Repositories;

namespace Fiap.Exemplo03.Console
{
    class Program
    {       

        static void Main(string[] args)
        {            
            // 0 -> Listar / 1 -> Cadastrar/ 2 -> Alterar / 3 -> Deletar
            System.Console.WriteLine("Entre com um código:");
            int codigo = Convert.ToInt32(System.Console.ReadLine());
            Repository.Cadastrar();
        }
    }
}
