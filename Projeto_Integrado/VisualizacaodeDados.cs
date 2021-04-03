using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto_Integrado
{
    public partial class VisualizacaodeDados : Form
    {
        public VisualizacaodeDados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuAluno = new MenuAluno();
            MenuAluno.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            string tabela = "aluno";
            string nameId = "numero_matricula";
            List<Aluno> alunos = new List<Aluno>();


            aluno.SelectById(tabela, nameId, int.Parse(txtMatricula.Text), alunos);
            foreach (Aluno aluno1 in alunos)
            {
                txtNome.Text = aluno1.Nome;
                txtCpf.Text = aluno1.Cpf;
                txtEmail.Text = aluno1.Email;
                txtTel.Text = aluno1.Telefone.ToString();
                dtNascimento.Text = aluno1.Dt_Nascimento.ToString();
            }
        }
    }
}
