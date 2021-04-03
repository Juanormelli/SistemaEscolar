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
        public string conexao = "";
        public MySqlConnection con = null;

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

        public void SelectById(string nametable, string nameid, int id,List<Aluno>select)
        {
            string Select = "Select * from " + nametable + " where " + nameid + "=@id";
            con = new MySqlConnection(conexao);
            MySqlCommand cmdSelect = new MySqlCommand(Select, con);
            //cmdSelect.Parameters.AddWithValue("@nametable", nametable);
            //cmdSelect.Parameters.AddWithValue("@nameid", nameid);
            cmdSelect.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader myreader;
            myreader = cmdSelect.ExecuteReader();
            while (myreader.Read())
            {
                select.Add(new Aluno()
                {
                    Nome = myreader["nome"].ToString(),
                    Cpf = myreader["cpf"].ToString(),
                    Email = myreader["email"].ToString(),
                    Dt_Nascimento = Convert.ToDateTime(myreader["dt_nascimento"]),
                    Telefone = Convert.ToInt64(myreader["telefone"]),

                });
               
            }
        }



    }
}
