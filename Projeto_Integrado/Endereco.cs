using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
    class Endereco:Conexao
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }




        public void Cadastrar_Endereco(Endereco endereco)
        {
            string sql = "Insert Into endereco values(@,@Rua,@Numero,@Bairro,@Cidade,@Estado)";
            con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Rua", endereco.Rua);
            cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
            cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
            cmd.Parameters.AddWithValue("@Estado", endereco.Estado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
