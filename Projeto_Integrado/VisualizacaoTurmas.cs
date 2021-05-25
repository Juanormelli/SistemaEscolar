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
    public partial class VisualizacaoTurmas : Form
    {
        public VisualizacaoTurmas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuTurma = new MenuTurmas();
            MenuTurma.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new gestaoescolarEntities())
            {
                var codturma = cbCdTurma.Text;
                var checkExistTurma = context.turma.Where(x => x.cd_turma == codturma).FirstOrDefault();
                
                if (checkExistTurma == null)
                {
                    MessageBox.Show("Esta turma nao existe !!");

                }

                else
                {
                    try
                    {
                        var alunos = context.aluno.Select(x=> new { Matricula=x.numero_matricula , Nome = x.nome , Turma = x.cd_turma }).Where(x => x.Turma == codturma).ToList();
                        var alunosok= alunos.Select(x => new { Matricula = x.Matricula, Nome = x.Nome }).ToList();
                        

                        dataGridView1.DataSource= alunosok;


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao recuperar a turma tente novamente ");
                    }
                }
            }
        }
    }
}
