using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
    class Conexao
    {
        public string conexao = "";
        public MySqlConnection con = null;

        public Conexao()
        {
            conexao = "server=localhost; user id=root;password=;database=gestaoescolar";
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

        public void SelectById(string nametable, string nameid, int id,List<Aluno>selectAluno)
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
                selectAluno.Add(new Aluno()
                {
                    Nome = myreader["nome"].ToString(),
                    Cpf = myreader["cpf"].ToString(),
                    Email = myreader["email"].ToString(),
                    Dt_Nascimento = Convert.ToDateTime(myreader["dt_nascimento"]),
                    Telefone = Convert.ToInt64(myreader["telefone"]),
                    
                   

                }) ;
               
            }
        }
        public void ClearTxtBoxes(Control.ControlCollection ctrl)
        {
            foreach (Control ctr2 in ctrl)
            {
                if (ctr2 is TextBoxBase || ctr2 is DateTimePicker || ctr2 is ComboBox )
                {
                    ctr2.Text = "";
                    
                }
                else
                {
                    ClearTxtBoxes(ctr2.Controls);
                }
            }

        }
        public bool CheckEmptyTxtBox(Control.ControlCollection ctrl)
        {
            bool check = true;
            foreach (Control ctr2 in ctrl)
            {
                if (ctr2 is TextBoxBase)
                {
                    if (!string.IsNullOrEmpty(ctr2.Text))
                    {
                        check = true;


                    }
                    else
                    {
                        check = false;
                        MessageBox.Show("Nenhum Valor Pode ser Vazio ");
                        break;
                    }
                }

            }
            return check;
        }


    }
}
