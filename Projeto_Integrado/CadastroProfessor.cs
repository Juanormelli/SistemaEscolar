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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (var context = new gestaoescolarEntities())
            {
                var professor = new professor()
                {
                    cod_reg = int.Parse(txtRegistro.Text),
                    nome = txtNome.Text,
                    periodo = cbPeriodo.Text
                };

                context.professor.Add(professor);
                context.SaveChanges();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var menu = new MenuProfessor();
            menu.Show();
        }
    }
}
