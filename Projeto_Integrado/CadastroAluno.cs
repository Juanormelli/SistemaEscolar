using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Projeto_Integrado
{
    public partial class CadastroAluno : Form
    {
        public void CheckEmptyTxtBox(Control.ControlCollection ctrl)
        {
            foreach (Control ctr2 in ctrl) {
                if (ctr2 is TextBoxBase)
                {
                    if (!string.IsNullOrEmpty(ctr2.Text))
                        continue;
                    else
                    {
                        MessageBox.Show("Nenhum Valor Pode ser Vazio ");
                        break;
                    }
                }
              
            }
        }
        public void ClearTxtBoxes(Control.ControlCollection ctrl)
        {
            foreach(Control ctr2 in ctrl)
            {
                if (ctr2 is TextBoxBase)
                {
                    ctr2.Text = "";
                }
                else
                {
                    ClearTxtBoxes(ctr2.Controls);
                }
            }

        }
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
            var aluno = new Aluno();
            aluno.A_Endereco = new Endereco();
            aluno.A_Responsavel = new Responsavel();
            aluno.Nome = txtNome.Text;
            aluno.Cpf = txtCpf.Text;
            aluno.Rg = txtRg.Text;
            aluno.Dt_Nascimento = dtNascimento.Value;
            aluno.Telefone = 1144;
            aluno.A_Endereco.Rua = txtRua.Text;
            aluno.A_Endereco.Numero = 44;
            aluno.A_Endereco.Bairro = txtBairro.Text;
            aluno.A_Endereco.Cidade = txtCidade.Text;
            aluno.A_Endereco.Estado = cbEstado.Text;
            aluno.A_Responsavel.Nome_Pai = txtNomePai.Text;
            aluno.A_Responsavel.Nome_Mae = txtNomeMae.Text;
            aluno.A_Responsavel.Telefone_Pai = 0;
            aluno.A_Responsavel.Telefone_Mae = 0;
            aluno.A_Responsavel.Email_Pai = txtEmailPai.Text;
            aluno.A_Responsavel.Email_Mae = txtEmailMae.Text;
            aluno.A_Responsavel.Cpf_Pai = txtCpfPai.Text;
            aluno.A_Responsavel.Cpf_Mae = txtCpfMae.Text;
            aluno.Principal_responsavel = "p";
            CheckEmptyTxtBox(this.Controls);

            try
            {
                aluno.A_Endereco.Cadastrar_Endereco(aluno.A_Endereco);
                aluno.A_Responsavel.Cadastrar_Resp(aluno.A_Responsavel);
                aluno.Cadastrar_Aluno(aluno);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult ok = MessageBox.Show("Cadastro Realizado", "Voltando para tela de cadstro", buttons);


                if (ok == DialogResult.OK)
                {
                    ClearTxtBoxes(this.Controls);
                }

            }
            catch
            {
                
            }
        }
    }
}
