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
    public partial class TrancarMatricula : Form
    {
        public TrancarMatricula()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var matricula = int.Parse(txtMatricula.Text);
            using (var context = new gestaoescolarEntities())
            {
                var aluno = context.aluno.Select(x => new { x.nome, x.cd_turma, x.situacao_matricula, x.numero_matricula }).Where(x => x.numero_matricula == matricula).ToList();
                if (aluno.Count != 0) 
                {
                    txtSmatricula.Text = aluno[0].situacao_matricula;
                    txtNome.Text = aluno[0].nome;
                    txtTurma.Text = aluno[0].cd_turma;
                    txtMatricula.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Numero de Matricula Invalido");
                }


            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var matricula = int.Parse(txtMatricula.Text);
            using (var context = new gestaoescolarEntities())
            {
                var aluno = context.aluno.Where(x => x.numero_matricula == matricula).First();
                if (aluno.situacao_matricula == "T")
                {
                    MessageBox.Show("O Aluno ja esta com a matricula trancada ");
                    var function = new Functions();
                    function.ClearTxtBoxes(this.Controls);
                    txtMatricula.ReadOnly = false;

                }
                else
                {
                    aluno.situacao_matricula = "T";

                    context.SaveChanges();

                    MessageBox.Show("Matricula trancada com sucesso ");

                    var function = new Functions();
                    function.ClearTxtBoxes(this.Controls);

                    txtMatricula.ReadOnly = false;
                }



            }
        }
    }
}
