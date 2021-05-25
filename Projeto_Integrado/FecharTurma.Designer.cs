namespace Projeto_Integrado
{
    partial class FecharTurma
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.BtnEncerrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbCdTurma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(140, 58);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 20);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Turma";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(233, 131);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(151, 20);
            this.dtInicio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data de Incio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Professor (Numero de Registro)";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(34, 188);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(151, 20);
            this.txtProfessor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sala";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(34, 131);
            this.txtSala.Name = "txtSala";
            this.txtSala.ReadOnly = true;
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 9;
            // 
            // BtnEncerrar
            // 
            this.BtnEncerrar.Location = new System.Drawing.Point(280, 241);
            this.BtnEncerrar.Name = "BtnEncerrar";
            this.BtnEncerrar.Size = new System.Drawing.Size(104, 20);
            this.BtnEncerrar.TabIndex = 17;
            this.BtnEncerrar.Text = "Encerrar Turma";
            this.BtnEncerrar.UseVisualStyleBackColor = true;
            this.BtnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(11, 12);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 23);
            this.btnVoltar.TabIndex = 98;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbCdTurma
            // 
            this.cbCdTurma.FormattingEnabled = true;
            this.cbCdTurma.Items.AddRange(new object[] {
            "1SA",
            "1SB",
            "2SA",
            "2SB",
            "3SA",
            "3SB"});
            this.cbCdTurma.Location = new System.Drawing.Point(34, 59);
            this.cbCdTurma.Name = "cbCdTurma";
            this.cbCdTurma.Size = new System.Drawing.Size(81, 21);
            this.cbCdTurma.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Professor (Nome)";
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(233, 188);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.ReadOnly = true;
            this.txtNomeProf.Size = new System.Drawing.Size(151, 20);
            this.txtNomeProf.TabIndex = 105;
            // 
            // FecharTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.cbCdTurma);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnEncerrar);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "FecharTurma";
            this.Text = "FecharTurma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Button BtnEncerrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbCdTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeProf;
    }
}