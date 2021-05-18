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

            using (var context = new gestaoescolarEntities())
            {

                var user = usuarioTxt.Text;
                var senha = senhaTxt.Text;
                IQueryable<usuario> users = context.usuario;
                users= users.Where(x => x.usuario1 == user);
                users = users.Where(x => x.senha == senha);
                var result = users.ToList();
                
                if (result.Count != 0)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalida");

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using(var context = new gestaoescolarEntities())
            {
                var teste = context.usuario.Select(x => x.usuario1);
                if(teste == null)
                {
                    var user = new usuario();

                    user.usuario1 = "admin";
                    user.senha = "admin";

                    context.usuario.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("O usuario é admin e a Senha é Admin !");
                }
               else 
                {
                    MessageBox.Show("Este não é o primeiro uso Contate o Administrador do sistema!");

                }


            }
           

        }
    }
}
