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
    public partial class AdicionarAlunos : Form
    {
        public AdicionarAlunos()
        {
            InitializeComponent();
        }

        private void AdicionarAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuTurma = new MenuTurmas();
            MenuTurma.Show();
        }

        private void BtnAdiconar_Click(object sender, EventArgs e)
        {
            using(var context = new gestaoescolarEntities())
            {
                var matricula = int.Parse(txtMatricula.Text);

                var checkAlunoExist = context.aluno.Where(x => x.numero_matricula == matricula).FirstOrDefault();

                if (checkAlunoExist == null)
                {
                    MessageBox.Show("O numero de matricula nao existe !!");
                }
                else
                {
                    var cdturma = cbCdTurma.Text;
                    var checkTurmaExist = context.turma.Where(x => x.cd_turma == cdturma).FirstOrDefault();

                    if (checkTurmaExist == null)
                    {
                        MessageBox.Show("A turma nao existe !!");
                    }
                    else
                    {
                        if (checkAlunoExist.cd_turma != null)
                        {
                            MessageBox.Show("Aluno cadastrado em outra Turma !!");
                        }
                        else
                        {
                            try
                            {
                                checkAlunoExist.cd_turma = cdturma;

                                context.SaveChanges();

                                MessageBox.Show("O Aluno foi cadastrado na turma com sucesso !!");

                                var functions = new Functions();

                                functions.ClearTxtBoxes(this.Controls);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Ocoreu um Erro no cadastro tente novamente !!");
                            }
                        }

                        

                        
                        
                    } 
                }
            }
        }
    }
}
