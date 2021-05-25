namespace Projeto_Integrado
{
    partial class MenuTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirTurma = new System.Windows.Forms.Button();
            this.btnFecharTurma = new System.Windows.Forms.Button();
            this.btnCdAluno = new System.Windows.Forms.Button();
            this.btnVisualizarTurm = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ações Turma";
            // 
            // btnAbrirTurma
            // 
            this.btnAbrirTurma.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAbrirTurma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirTurma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTurma.ForeColor = System.Drawing.Color.White;
            this.btnAbrirTurma.Location = new System.Drawing.Point(62, 99);
            this.btnAbrirTurma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbrirTurma.Name = "btnAbrirTurma";
            this.btnAbrirTurma.Size = new System.Drawing.Size(172, 62);
            this.btnAbrirTurma.TabIndex = 2;
            this.btnAbrirTurma.Text = "Abrir Turma";
            this.btnAbrirTurma.UseVisualStyleBackColor = false;
            this.btnAbrirTurma.Click += new System.EventHandler(this.btnAbrirTurma_Click);
            // 
            // btnFecharTurma
            // 
            this.btnFecharTurma.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTurma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharTurma.ForeColor = System.Drawing.Color.Red;
            this.btnFecharTurma.Location = new System.Drawing.Point(62, 167);
            this.btnFecharTurma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFecharTurma.Name = "btnFecharTurma";
            this.btnFecharTurma.Size = new System.Drawing.Size(172, 64);
            this.btnFecharTurma.TabIndex = 5;
            this.btnFecharTurma.Text = "Fechar Turma";
            this.btnFecharTurma.UseVisualStyleBackColor = false;
            this.btnFecharTurma.Click += new System.EventHandler(this.btnFecharTurma_Click);
            // 
            // btnCdAluno
            // 
            this.btnCdAluno.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCdAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCdAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdAluno.ForeColor = System.Drawing.Color.White;
            this.btnCdAluno.Location = new System.Drawing.Point(277, 99);
            this.btnCdAluno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCdAluno.Name = "btnCdAluno";
            this.btnCdAluno.Size = new System.Drawing.Size(172, 62);
            this.btnCdAluno.TabIndex = 7;
            this.btnCdAluno.Text = "Cadastrar Aluno";
            this.btnCdAluno.UseVisualStyleBackColor = false;
            this.btnCdAluno.Click += new System.EventHandler(this.btnCdAluno_Click);
            // 
            // btnVisualizarTurm
            // 
            this.btnVisualizarTurm.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarTurm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizarTurm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarTurm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarTurm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarTurm.ForeColor = System.Drawing.Color.DimGray;
            this.btnVisualizarTurm.Location = new System.Drawing.Point(277, 167);
            this.btnVisualizarTurm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVisualizarTurm.Name = "btnVisualizarTurm";
            this.btnVisualizarTurm.Size = new System.Drawing.Size(172, 66);
            this.btnVisualizarTurm.TabIndex = 9;
            this.btnVisualizarTurm.Text = "Visualizar Turmas\r\n";
            this.btnVisualizarTurm.UseVisualStyleBackColor = false;
            this.btnVisualizarTurm.Click += new System.EventHandler(this.btnVisualizarTurm_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(11, 12);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // MenuTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 278);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVisualizarTurm);
            this.Controls.Add(this.btnCdAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirTurma);
            this.Controls.Add(this.btnFecharTurma);
            this.Name = "MenuTurmas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirTurma;
        private System.Windows.Forms.Button btnFecharTurma;
        private System.Windows.Forms.Button btnCdAluno;
        private System.Windows.Forms.Button btnVisualizarTurm;
        private System.Windows.Forms.Button btnVoltar;
    }
}