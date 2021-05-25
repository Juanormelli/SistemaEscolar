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
    public partial class FecharTurma : Form
    {

        public FecharTurma()
        {
            InitializeComponent();
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

                var codTurma = cbCdTurma.Text;


                var selectTurma = context.turma.Where(x => x.cd_turma == codTurma).FirstOrDefault();
                if (selectTurma == null)
                {
                    MessageBox.Show("Turma nao existe !!");

                }
                else
                {
                    var selectprofessor = context.professor.Select(x => new { x.nome, x.cod_reg, x.cd_turma }).Where(x => x.cd_turma == codTurma).FirstOrDefault();
                    txtNomeProf.Text = selectprofessor.nome;
                    txtSala.Text = selectTurma.sala.ToString();
                    txtProfessor.Text = selectprofessor.cod_reg.ToString();
                    dtInicio.Value = DateTime.Parse(selectTurma.data_inicio);
                }
            }
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            var codTurma = cbCdTurma.Text;
            using (var context = new gestaoescolarEntities())
            {
                var selectTurma = context.turma.Where(x => x.cd_turma == codTurma).FirstOrDefault();

                var selectAlunos = context.aluno.Where(x => x.cd_turma == codTurma).ToList();

                var selectprofessor = context.professor.Where(x => x.cd_turma == codTurma).FirstOrDefault();

                if (selectAlunos == null)
                {
                    var teste = MessageBox.Show("Aviso", "Deseja realmente excluir a turma ?", MessageBoxButtons.YesNo);

                    if(teste == DialogResult.Yes)
                    {
                        selectprofessor.cd_turma = "";
                        context.turma.Remove(selectTurma);

                        context.SaveChanges();


                        MessageBox.Show("Turma Excluida com sucesso");
                    }
                    
                    
                     

                }
                else
                {
                    var count = selectAlunos.Count();
                    var str = "Existem "+count+" alunos na turma, Deseja mesmo excluir a turma ?"; 
                    var teste = MessageBox.Show(str.ToUpper(),"Aviso",MessageBoxButtons.YesNo);

                    if (teste == DialogResult.Yes)
                    {
                        foreach(var aluno in selectAlunos)
                        {
                            aluno.cd_turma = null;
                        }
                        
                        context.turma.Remove(selectTurma);

                        context.SaveChanges();
                        selectprofessor.cd_turma = null;
                        context.SaveChanges();

                        MessageBox.Show("Turma Excluida com sucesso");
                    }
                }
               


            }
        }
    }
}
