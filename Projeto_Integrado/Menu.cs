﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuAluno = new MenuAluno();
            MenuAluno.Show();
        }

        private void turmas_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var MenuTurmas = new MenuTurmas();
            MenuTurmas.Show();

        }
    }
}
