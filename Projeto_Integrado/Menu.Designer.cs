namespace Projeto_Integrado
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.turmas = new System.Windows.Forms.Button();
            this.Aluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // turmas
            // 
            this.turmas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.turmas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("turmas.BackgroundImage")));
            this.turmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.turmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turmas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.turmas.Location = new System.Drawing.Point(306, 65);
            this.turmas.Name = "turmas";
            this.turmas.Size = new System.Drawing.Size(146, 134);
            this.turmas.TabIndex = 0;
            this.turmas.Text = "Turmas";
            this.turmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.turmas.UseVisualStyleBackColor = false;
            // 
            // Aluno
            // 
            this.Aluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aluno.BackgroundImage")));
            this.Aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Aluno.Location = new System.Drawing.Point(24, 65);
            this.Aluno.Name = "Aluno";
            this.Aluno.Size = new System.Drawing.Size(153, 134);
            this.Aluno.TabIndex = 0;
            this.Aluno.Text = "Alunos";
            this.Aluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aluno.UseVisualStyleBackColor = false;
            this.Aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Incial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.turmas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turmas;
        private System.Windows.Forms.Button Aluno;
        private System.Windows.Forms.Label label1;
    }
}