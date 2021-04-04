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
        public int CodEndereco { get; set; }




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
        public void UpdateEndereco(int id, Endereco endereco)
        {
            string enderecoUpdate = "update endereco set rua=@Rua,numero=@Numero,bairro=@Bairro,cidade=@Cidade,estado=@Estado where cod_endereco=@id";
            con = new MySqlConnection(conexao);
            MySqlCommand cmdUpdateEndereco = new MySqlCommand(enderecoUpdate, con);
            cmdUpdateEndereco.Parameters.AddWithValue("@id", id);
            cmdUpdateEndereco.Parameters.AddWithValue("@Rua", endereco.Rua);
            cmdUpdateEndereco.Parameters.AddWithValue("@Numero", endereco.Numero);
            cmdUpdateEndereco.Parameters.AddWithValue("@Bairro", endereco.Bairro);
            cmdUpdateEndereco.Parameters.AddWithValue("@Cidade", endereco.Cidade);
            cmdUpdateEndereco.Parameters.AddWithValue("@Estado", endereco.Estado);
            con.Open();
            cmdUpdateEndereco.ExecuteNonQuery();
            con.Close();

        }
    }
}
