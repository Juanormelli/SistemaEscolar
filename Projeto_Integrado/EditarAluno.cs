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
            var matricula = int.Parse(txtMatricula.Text);
            using (var gestao = new gestaoescolarEntities())
            {
                var aluno = gestao.aluno.Where(x => x.numero_matricula == matricula).ToList();
                if (aluno.Count!=0) {
                    txtNome.Text = aluno[0].nome;
                    txtCpf.Text = aluno[0].cpf;
                    txtEmail.Text = aluno[0].email;
                    txtRg.Text = aluno[0].rg;
                    dtNascimento.Value = DateTime.Parse(aluno[0].dt_nascimento);
                    celMask.Text = aluno[0].telefone;
                    txtRua.Text = aluno[0].rua;
                    txtNum.Text = aluno[0].numero.ToString();
                    txtBairro.Text = aluno[0].bairro;
                    txtCidade.Text = aluno[0].cidade;
                    cbEstado.Text = aluno[0].estado;
                    var responsaveis = aluno[0].responsaveis.ToList();
                    txtNomePai.Text = responsaveis[0].nome_resposavel;
                    txtNomeMae.Text = responsaveis[1].nome_resposavel;
                    txtTelPai.Text = responsaveis[0].telefone_responsavel;
                    txtTelMae.Text = responsaveis[1].telefone_responsavel;
                    txtEmailPai.Text = responsaveis[0].email_responsavel;
                    txtEmailMae.Text = responsaveis[1].email_responsavel;
                    txtCpfPai.Text = responsaveis[0].cpf_resposnavel;
                    txtCpfMae.Text = responsaveis[1].cpf_resposnavel;


                    txtMatricula.ReadOnly = true;
                }

                else
                {
                    MessageBox.Show("Este numero de matricula nao existe!");
                }
                
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var matricula = int.Parse(txtMatricula.Text);
            using (var context = new gestaoescolarEntities())
            {
                var aluno = context.aluno.Where(x => x.numero_matricula == matricula).First();
                aluno.nome= txtNome.Text;
                aluno.cpf= txtCpf.Text.Replace("-", "").Replace(",", "");
                aluno.email = txtEmail.Text;
                aluno.rg= txtRg.Text;
                aluno.dt_nascimento= dtNascimento.Text;
                aluno.telefone = celMask.Text.Replace("-", "").Replace(".", "").Replace(" ", "");
                aluno.rua= txtRua.Text;
                aluno.numero = int.Parse(txtNum.Text);
                aluno.bairro =  txtBairro.Text;
                aluno.cidade = txtCidade.Text;
                aluno.estado= cbEstado.Text;
                var responsaveis = aluno.responsaveis.ToList();
                responsaveis[1].nome_resposavel=txtNomePai.Text;
                responsaveis[0].nome_resposavel= txtNomeMae.Text;
                responsaveis[1].telefone_responsavel= txtTelPai.Text.Replace("-", "").Replace(",", "").Replace(" ", "");

                responsaveis[0].telefone_responsavel = txtTelMae.Text.Replace("-", "").Replace(",", "").Replace(" ", "");
                responsaveis[1].email_responsavel = txtEmailPai.Text;
                responsaveis[0].email_responsavel = txtEmailMae.Text;
                responsaveis[1].cpf_resposnavel = txtCpfPai.Text.Replace("-", "").Replace(",", "");
                responsaveis[0].cpf_resposnavel = txtCpfMae.Text.Replace("-", "").Replace(",", "");

                context.SaveChanges();

                var functions = new Functions();

                functions.ClearTxtBoxes(this.Controls);
                txtMatricula.ReadOnly = false;

            }
           



           

            


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}

