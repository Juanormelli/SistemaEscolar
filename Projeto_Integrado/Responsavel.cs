using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_Integrado
{
    class Responsavel : Conexao
    {
        public string Nome_Pai { get; set; }
        public string Nome_Mae { get; set; }
        public long Telefone_Pai { get; set; }
        public long Telefone_Mae { get; set; }
        public string Email_Pai { get; set; }
        public string Email_Mae { get; set; }

        public string Cpf_Pai { get; set; }
        public string Cpf_Mae { get; set; }
        public int CodResponsaveis { get; set; }

        public void Cadastrar_Responsaveis(Responsavel responsaveis)
        {
            string sql = "Insert Into responsaveis values(@,@NomePai,@NomeMae,@EmailPai,@EmailMae,@TelefonePai,@TelefoneMae,@CpfPai,@CpfMae)";
            string verificacao = "Select count(*) from responsaveis where cpf_pai=@CpfPai or cpf_mae=@CpfMae";


            con = new MySqlConnection(conexao);
            MySqlCommand cmdCadastro = new MySqlCommand(sql, con);
            cmdCadastro.Parameters.AddWithValue("@NomePai", responsaveis.Nome_Pai);
            cmdCadastro.Parameters.AddWithValue("@NomeMae", responsaveis.Nome_Mae);
            cmdCadastro.Parameters.AddWithValue("@TelefonePai", responsaveis.Telefone_Pai);
            cmdCadastro.Parameters.AddWithValue("@TelefoneMae", responsaveis.Telefone_Mae);
            cmdCadastro.Parameters.AddWithValue("@EmailPai", responsaveis.Email_Pai);
            cmdCadastro.Parameters.AddWithValue("@EmailMae", responsaveis.Email_Mae);
            cmdCadastro.Parameters.AddWithValue("@CpfPai", responsaveis.Cpf_Pai);
            cmdCadastro.Parameters.AddWithValue("@CpfMae", responsaveis.Cpf_Mae);

            MySqlCommand cmdVerificacao = new MySqlCommand(verificacao, con);
            cmdVerificacao.Parameters.AddWithValue("@CpfPai", responsaveis.Cpf_Pai);
            cmdVerificacao.Parameters.AddWithValue("@CpfMae", responsaveis.Cpf_Mae);

            int count = -1;
            con.Open();
            count = int.Parse(cmdVerificacao.ExecuteScalar() + "");
            if (count != -1)
            {
                cmdCadastro.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("Os pais ja estao cadastrados");
            }

            con.Close();
        }
        public void UpdateResponsaveis(int id, Responsavel responsaveis)
        {
            string updateResponsaveis = "Update responsaveis set nome_pai=@NomePai,nome_mae=@NomeMae,email_pai=@EmailPai,email_mae=@EmailMae,telefone_pai=@TelefonePai,telefone_mae=@TelefoneMae,cpf_pai=@CpfPai,cpf_mae=@CpfMae where cod_responsaveis=@id";


            con = new MySqlConnection(conexao);
            MySqlCommand cmdUpdate = new MySqlCommand(updateResponsaveis, con);
            cmdUpdate.Parameters.AddWithValue("@id", id);
            cmdUpdate.Parameters.AddWithValue("@NomePai", responsaveis.Nome_Pai);
            cmdUpdate.Parameters.AddWithValue("@NomeMae", responsaveis.Nome_Mae);
            cmdUpdate.Parameters.AddWithValue("@TelefonePai", responsaveis.Telefone_Pai);
            cmdUpdate.Parameters.AddWithValue("@TelefoneMae", responsaveis.Telefone_Mae);
            cmdUpdate.Parameters.AddWithValue("@EmailPai", responsaveis.Email_Pai);
            cmdUpdate.Parameters.AddWithValue("@EmailMae", responsaveis.Email_Mae);
            cmdUpdate.Parameters.AddWithValue("@CpfPai", responsaveis.Cpf_Pai);
            cmdUpdate.Parameters.AddWithValue("@CpfMae", responsaveis.Cpf_Mae);
            con.Open();
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }




    }
}
