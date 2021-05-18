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
    public partial class MenuProfessor : Form
    {
        public MenuProfessor()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            var cadastrar = new CadastroProfessor();
            this.Hide();
            this.Close();
            cadastrar.Show();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var visualizar = new VisualizarDadosProf();
            this.Hide();
            this.Close();
            visualizar.Show();
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var editar = new AtualizarDadosProfessor();
            editar.Show();
        }
    }
}
