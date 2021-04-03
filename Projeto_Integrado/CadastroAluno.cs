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

        public void ClearTxtBoxes(Control.ControlCollection ctrl)
        {
            foreach (Control ctr2 in ctrl)
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
            if (CheckEmptyTxtBox(this.Controls))
            {
                var aluno = new Aluno();
                aluno.A_Endereco = new Endereco();
                aluno.A_Responsavel = new Responsavel();
                aluno.Nome = txtNome.Text;
                aluno.Cpf = txtCpf.Text.Replace("-", "").Replace(",", "");
                aluno.Email = txtEmail.Text;
                aluno.Rg = txtRg.Text;
                aluno.Dt_Nascimento = dtNascimento.Value;
                aluno.Telefone = long.Parse(celMask.Text.Replace("-", "").Replace(".", "").Replace(" ", ""));
                aluno.A_Endereco.Rua = txtRua.Text;
                aluno.A_Endereco.Numero = int.Parse(txtNum.Text);
                aluno.A_Endereco.Bairro = txtBairro.Text;
                aluno.A_Endereco.Cidade = txtCidade.Text;
                aluno.A_Endereco.Estado = cbEstado.Text;
                aluno.A_Responsavel.Nome_Pai = txtNomePai.Text;
                aluno.A_Responsavel.Nome_Mae = txtNomeMae.Text;
                aluno.A_Responsavel.Telefone_Pai = long.Parse(txtTelPai.Text.Replace("-", "").Replace(",", "").Replace(" ", ""));
              
                aluno.A_Responsavel.Telefone_Mae = long.Parse(txtTelMae.Text.Replace("-", "").Replace(",", "").Replace(" ", ""));
                aluno.A_Responsavel.Email_Pai = txtEmailPai.Text;
                aluno.A_Responsavel.Email_Mae = txtEmailMae.Text;
                aluno.A_Responsavel.Cpf_Pai = txtCpfPai.Text.Replace("-", "").Replace(",", "");
                aluno.A_Responsavel.Cpf_Mae = txtCpfMae.Text.Replace("-", "").Replace(",", "");
                if (ckMae.Checked)
                {
                    aluno.Principal_responsavel = "M";
                }
                else if (ckPai.Checked)
                {
                    aluno.Principal_responsavel = "P";
                }
                else if (ckAmbos.Checked)
                {
                    aluno.Principal_responsavel = "A";
                }
                else
                {
                    MessageBox.Show("Voce Precisa selecionar um Responsavel principal");
                }

                try
                {
                    aluno.A_Endereco.Cadastrar_Endereco(aluno.A_Endereco);
                    aluno.A_Responsavel.Cadastrar_Responsaveis(aluno.A_Responsavel);
                    aluno.Cadastrar_Aluno(aluno);
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult ok = MessageBox.Show("Cadastro Realizado", "AVISO", buttons);


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
}
