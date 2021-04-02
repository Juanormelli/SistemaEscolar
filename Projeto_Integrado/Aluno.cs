using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
   
    class Aluno : Endereco
    {
        public int Numero_Matricula { get; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public int Telefone { get; set; }
        public string Principal_responsavel{ get; set; }
        public Endereco A_Endereco { get; set; }
        public Responsavel A_Responsavel { get; set; }
        

        MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root; Database=gestao_escolar; password= ");

        public void Cadastrar_Aluno(Aluno aluno)
        {
            var Con = new Conexao();
            Con.Cadastrar_Aluno(aluno);

        }


    }
}
