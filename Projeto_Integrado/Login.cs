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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void entarBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTxt.Text;
            string senha = senhaTxt.Text;

            var con = new Conexao();
            
            if (con.autenticacaousuario(usuario, senha))
            {
                var form = new Menu();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta ");
            }

        }   
    }
}
