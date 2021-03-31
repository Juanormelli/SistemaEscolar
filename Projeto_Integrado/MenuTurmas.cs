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
    public partial class MenuTurmas : Form
    {
        public MenuTurmas()
        {
            InitializeComponent();
        }
        public void MostrarForm(Form nome)
        {
            this.Hide();
            Close();
            nome.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var Menu = new Menu();
            MostrarForm(Menu);
        }

        private void btnAbrirTurma_Click(object sender, EventArgs e)
        {
            var CadastroTurma = new CadastroTurma();
            MostrarForm(CadastroTurma);
        }

        private void btnCdAluno_Click(object sender, EventArgs e)
        {
            var AdcAlunos = new AdicionarAlunos();
            MostrarForm(AdcAlunos);
        }

        private void btnFecharTurma_Click(object sender, EventArgs e)
        {
            var FecharTurma = new FecharTurma();
            MostrarForm(FecharTurma);
        }

        private void btnVisualizarTurm_Click(object sender, EventArgs e)
        {
            var VisualizarTurmas = new VisualizacaoTurmas();
            MostrarForm(VisualizarTurmas);
        }
    }
}
