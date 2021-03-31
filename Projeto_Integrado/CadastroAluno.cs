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
    public partial class CadastroAluno : Form
    {
        public void MostrarForm(Form nome)
        {
            this.Hide();
            this.Close();
            nome.Show();

        }
        public CadastroAluno()
        {
            InitializeComponent();
        }



        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            var MenuAlunos = new MenuAluno();
            MostrarForm(MenuAlunos);
        }
    }
}
