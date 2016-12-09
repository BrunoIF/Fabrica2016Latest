using Fiap.Exemplo03.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo03.Console.Repositories
{
    public class Repository : IRepository
    {        private HttpClient client = new HttpClient();
        /*public virtual IEnumerable<AlunoDTO> Listar()
        {
            client.BaseAddress = new Uri("http://localhost:58692/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Aluno").Result;
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<AlunoDTO> aluno =
                response.Content.ReadAsAsync<IEnumerable<AlunoDTO>>().Result;
                return aluno;    
            }           

        }*/

        public virtual void Cadastrar()
        {                        
            client.BaseAddress = new Uri("http://localhost:58692/");

            System.Console.WriteLine("Entre com o Nome:");
            string aluNome = System.Console.ReadLine();

            System.Console.WriteLine("Entre com a Data de Nascimento:");
            DateTime aluDataNascimento = Convert.ToDateTime(System.Console.ReadLine());

            bool aluBolsa;
            System.Console.WriteLine("O Aluno possui bolsa? S/N");
            string resposta = System.Console.ReadLine();
            if (resposta == "S" || resposta == "s")
            {
                aluBolsa = true;
            }
            else
            {
                aluBolsa = false;
            }

            System.Console.WriteLine("Entre com o grupo do aluno (id):");
            int aluGrupo = Convert.ToInt32(System.Console.ReadLine());

            var aluno = new AlunoDTO() { Nome = aluNome, DataNascimento = aluDataNascimento, Bolsa = aluBolsa, GrupoId = aluGrupo};
            HttpResponseMessage response =
            client.PostAsJsonAsync("api/Aluno", aluno).Result;
            if (response.IsSuccessStatusCode)
            {
                Uri uri = response.Headers.Location;
            }

        }

    }
}
