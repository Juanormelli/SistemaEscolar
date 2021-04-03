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
        public void Cadastrar_Aluno(Aluno aluno)
        {
            string endereco = "Select cod_endereco from endereco where rua=@Rua and numero=@Numero and bairro=@Bairro and cidade=@Cidade and estado=@Estado";
            string cadastrarAluno = "insert into aluno values(@,@Nome,@cpf,@rg,@dtNascimento,@telefone,@CodEndereco,@CodResponsavel,@PrincipalResp)";
            string responsavel = "Select cod_responsaveis from responsaveis where cpf_pai=@CpfPai and cpf_mae=@CpfMae ";
            con = new MySqlConnection(conexao);
            con.Open();

            MySqlCommand cmdSelectEndereco = new MySqlCommand(endereco, con);
            cmdSelectEndereco.Parameters.AddWithValue("@Rua", aluno.A_Endereco.Rua);
            cmdSelectEndereco.Parameters.AddWithValue("@Numero", aluno.A_Endereco.Numero);
            cmdSelectEndereco.Parameters.AddWithValue("@Bairro", aluno.A_Endereco.Bairro);
            cmdSelectEndereco.Parameters.AddWithValue("@Cidade", aluno.A_Endereco.Cidade);
            cmdSelectEndereco.Parameters.AddWithValue("@Estado", aluno.A_Endereco.Estado);
            MySqlDataReader readerEnd = cmdSelectEndereco.ExecuteReader();
            int codEndereco = -1;
            if (readerEnd.HasRows)
            {
                while (readerEnd.Read())
                {
                    codEndereco = readerEnd.GetInt32(0);

                }


            }

            readerEnd.Close();
            MySqlCommand cmdSelectResp = new MySqlCommand(responsavel, con);
            cmdSelectResp.Parameters.AddWithValue("@CpfPai", aluno.A_Responsavel.Cpf_Pai);
            cmdSelectResp.Parameters.AddWithValue("@CpfMae", aluno.A_Responsavel.Cpf_Mae);
            MySqlDataReader readerPais = cmdSelectResp.ExecuteReader();
            int codPais = -1;
            if (readerPais.HasRows)
            {
                while (readerPais.Read())
                {
                    codPais = readerPais.GetInt32(0);
                }


            }
            
            readerPais.Close();

            MySqlCommand cmdCadastrarAluno = new MySqlCommand(cadastrarAluno, con);
            cmdCadastrarAluno.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmdCadastrarAluno.Parameters.AddWithValue("@cpf", aluno.Cpf);
            cmdCadastrarAluno.Parameters.AddWithValue("@rg", aluno.Rg);
            cmdCadastrarAluno.Parameters.AddWithValue("@dtNascimento", aluno.Dt_Nascimento);
            cmdCadastrarAluno.Parameters.AddWithValue("@telefone", aluno.Telefone);
            cmdCadastrarAluno.Parameters.AddWithValue("@CodEndereco", codEndereco);
            cmdCadastrarAluno.Parameters.AddWithValue("@CodResponsavel", codPais);
            cmdCadastrarAluno.Parameters.AddWithValue("@PrincipalResp", aluno.Principal_responsavel);
            if (codEndereco != -1 && codEndereco != 0 && codPais != -1 && codPais != 0)
            {
                cmdCadastrarAluno.ExecuteNonQuery();
            }

            con.Close();

        }

    }
}
