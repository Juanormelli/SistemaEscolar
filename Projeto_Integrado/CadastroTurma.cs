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
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuTurma = new MenuTurmas();
            MenuTurma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new gestaoescolarEntities())
            {
                var cdregistro = int.Parse(txtRegistro.Text);

                var existProf = context.professor.Where(x => x.cod_reg == cdregistro).FirstOrDefault();

                if (existProf == null)
                {
                    MessageBox.Show("Professor nao existe !!");
                }
                else
                {

                    var professor = context.professor.Where(x => x.cod_reg == cdregistro).FirstOrDefault();
                    if (professor.cd_turma != null)
                    {
                        MessageBox.Show("Professor ja possui turma nao é possivel adicona-lo em outra turma !");
                    }
                    else
                    {

                        var sala = int.Parse(cbSala.Text);
                        

                        var checksala = context.turma.Where(x => x.sala == sala).FirstOrDefault();
                        if (checksala == null)
                        {
                            var codTurma = cbCdTurma.Text;

                            var cdTurmaUsed = context.turma.Where(x => x.cd_turma == codTurma).FirstOrDefault();
                            if (cdTurmaUsed != null)
                            {
                                MessageBox.Show("A turma ja existe Feche ela para poder abrir novamente !");
                            }
                            else
                            {
                                try
                                {
                                    var turma1 = new turma();
                                    turma1.cd_turma = cbCdTurma.Text;
                                    turma1.data_inicio = dtInicio.Text;
                                    turma1.sala = int.Parse(cbSala.Text);
                                    professor.cd_turma = cbCdTurma.Text;

                                    context.turma.Add(turma1);

                                    context.SaveChanges();

                                    MessageBox.Show("Turma cadastrada com Sucesso !! ");

                                    var functions = new Functions();
                                    
                                    functions.ClearTxtBoxes(this.Controls);



                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Ocorreu um erro com o cadastro, Tente novamente !!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sala ja esta em uso por outra turma, caso deseje abrir uma nova turma nesta sala sera necessario fechar a antiga turma ");
                        }


                    }
                }


            }
        }
    }
}
