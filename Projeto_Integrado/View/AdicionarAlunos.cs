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

        private void Adiconar_Click(object sender, EventArgs e)
        {

        }
    }
}
