using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
    class Conexao
    {
        string conexao = "";
        MySqlConnection con = null;

        public Conexao()
        {
            conexao = "server=localhost; user id=root;password=password1;database=gestao_escolar";
        }

        public bool autenticacaousuario(string usuario, string senha)
        {

            int count = -1;
            string sql = "Select count(*) from usuario where usuario=@usuario and senha=@senha";
            con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            con.Open();
            count = int.Parse(cmd.ExecuteScalar() + "");
            Console.WriteLine(count);
            con.Close();
            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

           


        }
    }
}
