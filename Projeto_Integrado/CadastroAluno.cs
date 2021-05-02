using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Projeto_Integrado
{
    public partial class CadastroAluno : Form
    {


        Functions functions = new Functions();
        public void MostrarForm(Form nome)
        {
            this.Hide();
            this.Close();
            nome.Show();

        }
        public CadastroAluno()
        {
            InitializeComponent();
        }



        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            var MenuAlunos = new MenuAluno();
            MostrarForm(MenuAlunos);
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (functions.CheckEmptyTxtBox(this.Controls))
            {

                var Nome = txtNome.Text;
                var Cpf = txtCpf.Text.Replace("-", "").Replace(",", "");
                var Email = txtEmail.Text;
                var Rg = txtRg.Text;
                var Dt_Nascimento = dtNascimento.Value;
                var Telefone = long.Parse(celMask.Text.Replace("-", "").Replace(".", "").Replace(" ", ""));
                var Rua = txtRua.Text;
                var Numero = int.Parse(txtNum.Text);
                var Bairro = txtBairro.Text;
                var Cidade = txtCidade.Text;
                var Estado = cbEstado.Text;
                var Nome_Pai = txtNomePai.Text;
                var Nome_Mae = txtNomeMae.Text;
                var Telefone_Pai = long.Parse(txtTelPai.Text.Replace("-", "").Replace(",", "").Replace(" ", ""));

                var Telefone_Mae = long.Parse(txtTelMae.Text.Replace("-", "").Replace(",", "").Replace(" ", ""));
                var Email_Pai = txtEmailPai.Text;
                var Email_Mae = txtEmailMae.Text;
                var Cpf_Pai = txtCpfPai.Text.Replace("-", "").Replace(",", "");
                var Cpf_Mae = txtCpfMae.Text.Replace("-", "").Replace(",", "");


              
                var mae = new responsaveis()
                {
                    cpf_resposnavel = Cpf_Mae,
                    email_responsavel = Email_Mae,
                    nome_resposavel = Nome_Mae,
                    telefone_responsavel = Telefone_Mae.ToString(),

                };
                var pai = new responsaveis()
                {
                    cpf_resposnavel = Cpf_Pai,
                    email_responsavel = Email_Pai,
                    nome_resposavel = Nome_Pai,
                    telefone_responsavel = Telefone_Pai.ToString(),
                };
                var aluno = new aluno()
                {
                    nome = Nome,
                    cpf = Cpf,
                    email = Email,
                    rg = Rg,
                    dt_nascimento = Dt_Nascimento.ToString(),
                    telefone = Telefone.ToString(),
                    rua = Rua,
                    numero = Numero,
                    bairro = Bairro,
                    cidade = Cidade,
                    estado = Estado,
                    situacao_matricula = "M",
                    responsaveis = new List<responsaveis> {mae,pai}

                };

                var validaAluno = aluno.ValidaAluno(aluno);
                var validaMae = mae.ValidaResponsavel(mae);
                var validaPai = pai.ValidaResponsavel(pai);

                if (validaAluno  && validaMae && validaPai)
                {
                    
                    
                    aluno.CadastrarAluno(aluno);



                    var matricula = aluno.RetornarMatricula(aluno);

                    
                    MessageBox.Show("Aluno Matriculado ! O Numero de matricula do mesmo é : " + matricula);

                    functions.ClearTxtBoxes(this.Controls);
                }
                else
                {
                    var matricula = aluno.RetornarMatricula(aluno);
                    MessageBox.Show("O Aluno já esta matriculado no numero de matricula : "+ matricula);
                    
                }

                

            }
            else
            {
                MessageBox.Show("Nenhum Campo pode ser vazio !");
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            functions.ClearTxtBoxes(this.Controls);
        }
    }
}
