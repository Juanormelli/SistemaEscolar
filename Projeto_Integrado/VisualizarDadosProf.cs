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
    public partial class VisualizarDadosProf : Form
    {
        public VisualizarDadosProf()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var registro = int.Parse(txtRegistro.Text);
            try
            {
                using (var context = new gestaoescolarEntities())
                {
                    var view = context.professor.Where(x => x.cod_reg == registro).ToList();
                    txtNome.Text = view[0].nome;
                    cdTurma.Text = view[0].cd_turma;
                    cbPeriodo.Text = view[0].periodo;

                }
            } 
            catch(Exception ex )
            {
                MessageBox.Show("O numero do resgistro nao existe !");
                var func = new Functions();
                func.ClearTxtBoxes(this.Controls);
            }
           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var func = new Functions();
            func.ClearTxtBoxes(this.Controls);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuProfessor();
            this.Hide();
            this.Close();
            menu.Show();
        }
    }
}
