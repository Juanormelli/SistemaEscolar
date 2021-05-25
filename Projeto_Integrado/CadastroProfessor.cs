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
            var functions = new Functions();
            var teste = functions.CheckEmptyTxtBox(this.Controls);
            if (teste == true)
            {
                using (var context = new gestaoescolarEntities())
                {
                    try
                    {
                        var professor = new professor()
                        {
                            cod_reg = int.Parse(txtRegistro.Text),
                            nome = txtNome.Text,
                            periodo = cbPeriodo.Text
                        };

                        context.professor.Add(professor);
                        context.SaveChanges();
                        MessageBox.Show("Professor Cadastrado com sucesso!");
                        functions.ClearTxtBoxes(this.Controls);
                    }
                    catch(Exception ex)
                    {
                        
                        var erro = MessageBox.Show(ex.Message+ ".  Deseja mostrar mais detalhes do erro ?","Erro", MessageBoxButtons.YesNo);
                        if (erro == DialogResult.Yes)
                        {
                            MessageBox.Show(ex.InnerException.ToString());
                        }
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode ser vazio !");
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
