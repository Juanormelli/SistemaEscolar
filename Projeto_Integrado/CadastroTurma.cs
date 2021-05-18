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
                var turma1 = new turma();
                turma1.cd_turma = cbCdTurma.Text;
                turma1.data_inicio = dtInicio.Text;
                turma1.sala = int.Parse(cbSala.Text);

                context.turma.Add(turma1);
                
                context.SaveChanges();

            }
        }
    }
}
