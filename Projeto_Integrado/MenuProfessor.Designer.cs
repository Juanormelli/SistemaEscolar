
namespace Projeto_Integrado
{
    partial class MenuProfessor
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(34, 17);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ações Professor";
            // 
            // btnMatricular
            // 
            this.btnMatricular.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMatricular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMatricular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricular.ForeColor = System.Drawing.Color.White;
            this.btnMatricular.Location = new System.Drawing.Point(34, 97);
            this.btnMatricular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(172, 62);
            this.btnMatricular.TabIndex = 12;
            this.btnMatricular.Text = "Cadastrar Professor";
            this.btnMatricular.UseVisualStyleBackColor = false;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.DimGray;
            this.btnView.Location = new System.Drawing.Point(136, 180);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(204, 66);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Visualizar Dados Professor";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterarDados.Location = new System.Drawing.Point(249, 97);
            this.btnAlterarDados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(183, 66);
            this.btnAlterarDados.TabIndex = 14;
            this.btnAlterarDados.Text = "Alterar Dados Professor";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // MenuProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 274);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAlterarDados);
            this.Name = "MenuProfessor";
            this.Text = "MenuProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAlterarDados;
    }
}