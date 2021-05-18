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
            var numero_matricula = int.Parse(txtMatricula.Text);
            var function = new Functions();

            using (var context = new gestaoescolarEntities())
            {
                var alunos = context.aluno.Where(x => x.numero_matricula == numero_matricula).ToList();
                if (alunos.Count != 0)
                {
                    txtNome.Text = alunos[0].nome;
                    txtCpf.Text = alunos[0].cpf;
                    txtEmail.Text = alunos[0].email;
                    txtTel.Text = alunos[0].telefone;
                    txtTurma.Text = alunos[0].cd_turma;
                    dtNascimento.Text = alunos[0].dt_nascimento;
                }
                else
                {
                    function.ClearTxtBoxes(this.Controls);
                    MessageBox.Show("Numero de Matricula Invalido !");
                }
               
            }





        }
    }

}
