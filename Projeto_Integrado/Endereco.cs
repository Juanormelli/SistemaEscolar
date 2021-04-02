using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
    class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }




        public void Cadastrar_Endereco(Endereco endereco)
        {
            var con = new Conexao();
            con.Cadastrar_Endereco(endereco);

            
        }
    }
}
