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
    public partial class AtualizarDadosProfessor : Form
    {
        
        public AtualizarDadosProfessor()
        {
            InitializeComponent();
            btnAlterar.Enabled= false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cdreg = int.Parse(txtRegistro.Text);
            
            using (var context = new gestaoescolarEntities())
            {
                
                var professor = context.professor.Where(x => x.cod_reg == cdreg).FirstOrDefault();
                if (professor == null)
                {
                    MessageBox.Show("Numero de registro nao existe !");
                }
                else
                {
                    txtNome.Text = professor.nome;
                    cbPeriodo.Text = professor.periodo;
                    txtRegistro.ReadOnly = true;
                    btnAlterar.Enabled = true;
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new gestaoescolarEntities())
                {
                    var cdreg = int.Parse(txtRegistro.Text);
                    var professor = context.professor.Where(x => x.cod_reg == cdreg).FirstOrDefault();
                    professor.nome = txtNome.Text;
                    professor.periodo = cbPeriodo.Text;
                    context.SaveChanges();

                   

                    var f = new Functions();

                    f.ClearTxtBoxes(this.Controls);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Dados do professor alterado !");
                txtRegistro.ReadOnly = false;
                btnAlterar.Enabled = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuProfessor();
            this.Hide();
            this.Close();
            menu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var function = new Functions();
            function.ClearTxtBoxes(this.Controls);
            btnAlterar.Enabled = false;
            txtRegistro.ReadOnly = false;
        }
    }
}
