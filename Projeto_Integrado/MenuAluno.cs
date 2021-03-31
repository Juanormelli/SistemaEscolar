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
    public partial class MenuAluno : Form
    {
        public MenuAluno()
        {
            InitializeComponent();
        }
        public void MostrarForm(Form nome) 
        {
            this.Hide();
            Close();
            nome.Show();

        }
        private void btnMatricular_Click(object sender, EventArgs e)
        {
            var CadastrarAluno = new CadastroAluno();
            MostrarForm(CadastrarAluno);
        }


        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            var EditarDados = new EditarAluno();
            MostrarForm(EditarDados);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            var VisualizarDados = new VisualizacaodeDados();
            MostrarForm(VisualizarDados);
        }

        private void btnTrncMatr_Click(object sender, EventArgs e)
        {
            var TrancarMatricula = new TrancarMatricula();
            MostrarForm(TrancarMatricula);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var Voltar = new Menu();
            MostrarForm(Voltar);
        }


       

        
    }
}
