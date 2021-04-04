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
    public partial class EditarAluno : Form
    {
        int codEndereco = 0;
        int codResp = 0;
        public EditarAluno()
        {
            InitializeComponent();
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {

        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuAluno = new MenuAluno();
            MenuAluno.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Aluno alunoaux = new Aluno();
            List<Aluno> alunos = new List<Aluno>();
            List<Endereco> enderecos = new List<Endereco>();
            List<Responsavel> responsaveis = new List<Responsavel>();
            
            int NumeroMatricula = int.Parse(txtMatricula.Text);


            alunoaux.SelectById(NumeroMatricula, alunos, enderecos, responsaveis);

            if (alunos.Count != 0)
            {
                foreach (Aluno aluno in alunos)
                {
                    txtNome.Text = aluno.Nome;
                    txtCpf.Text = aluno.Cpf;
                    txtRg.Text = aluno.Rg;
                    txtEmail.Text = aluno.Email;
                    celMask.Text = aluno.Telefone.ToString();
                    dtNascimento.Text = aluno.Dt_Nascimento.ToString();
                }
                foreach (Endereco endereco in enderecos)
                {
                    txtRua.Text = endereco.Rua;
                    txtNum.Text = endereco.Numero.ToString();
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    cbEstado.Text = endereco.Estado;
                    codEndereco = endereco.CodEndereco;
                }
                foreach (Responsavel responsavel in responsaveis)
                {
                    txtNomePai.Text = responsavel.Nome_Pai;
                    txtNomeMae.Text = responsavel.Nome_Mae;
                    txtTelPai.Text = responsavel.Telefone_Pai.ToString();
                    txtTelMae.Text = responsavel.Telefone_Mae.ToString();
                    txtEmailPai.Text = responsavel.Email_Pai;
                    txtEmailMae.Text = responsavel.Email_Mae;
                    txtCpfPai.Text = responsavel.Cpf_Pai;
                    txtCpfMae.Text = responsavel.Cpf_Mae;
                    codResp = responsavel.CodResponsaveis;

                }
            }
            else
            {
                MessageBox.Show("Matricula Invalida", "AVISO");
                alunoaux.ClearTxtBoxes(this.Controls);
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            if (aluno.CheckEmptyTxtBox(this.Controls))
            {
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
                    aluno.A_Endereco.UpdateEndereco(codEndereco,aluno.A_Endereco);
                    aluno.A_Responsavel.UpdateResponsaveis(codResp,aluno.A_Responsavel);
                    aluno.UpdateAluno(int.Parse(txtMatricula.Text),aluno);
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult ok = MessageBox.Show("Dados Alterados com sucesso !", "AVISO", buttons);


                    if (ok == DialogResult.OK)
                    {
                        aluno.ClearTxtBoxes(this.Controls);
                    }

                }
                catch(Exception)
                {
                   
                }
            }
        }
    }
}

