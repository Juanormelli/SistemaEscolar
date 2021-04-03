using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado
{
   
    class Aluno:Conexao
    {
        public int Numero_Matricula { get; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public long Telefone { get; set; }
        public string Principal_responsavel{ get; set; }
        public Endereco A_Endereco { get; set; }
        public Responsavel A_Responsavel { get; set; }
        

        

        public void Cadastrar_Aluno(Aluno aluno)
        {
            string endereco = "Select cod_endereco from endereco where rua=@Rua and numero=@Numero and bairro=@Bairro and cidade=@Cidade and estado=@Estado";
            string cadastrarAluno = "insert into aluno values(@,@Nome,@cpf,@rg,@dtNascimento,@telefone,@CodEndereco,@CodResponsavel,@PrincipalResp,@email)";
            string responsavel = "Select cod_responsaveis from responsaveis where cpf_pai=@CpfPai and cpf_mae=@CpfMae ";
            string deleteEnd = "delete from endereco where cod_endereco=@CodEndereco";
            string deleteResp = "delete from responsaveis where cod_responsaveeis=@CodResponsavel";

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
            cmdCadastrarAluno.Parameters.AddWithValue("@email", aluno.Email);

            if (codEndereco != -1 && codEndereco != 0 && codPais != -1 && codPais != 0)
            {
                var teste = cmdCadastrarAluno.ExecuteNonQuery();
                if (teste==0)
                {
                    Console.WriteLine(teste);
                    MySqlCommand cmdDeleteEnd = new MySqlCommand(deleteEnd, con);
                    MySqlCommand cmdDeleteResp = new MySqlCommand(deleteResp, con);
                    cmdDeleteEnd.Parameters.AddWithValue("@CodEndereco", codEndereco);
                    cmdDeleteResp.Parameters.AddWithValue("@CodResponsavel", codPais);

                }
            }

            con.Close();

        }



    }
}
