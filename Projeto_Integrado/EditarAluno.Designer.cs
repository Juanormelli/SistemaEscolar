namespace Projeto_Integrado
{
    partial class EditarAluno
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCpfPai = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfMae = new System.Windows.Forms.MaskedTextBox();
            this.txtTelPai = new System.Windows.Forms.MaskedTextBox();
            this.txtTelMae = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.celMask = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ckAmbos = new System.Windows.Forms.CheckBox();
            this.ckPai = new System.Windows.Forms.CheckBox();
            this.ckMae = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtEmailMae = new System.Windows.Forms.TextBox();
            this.txtEmailPai = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(32, 66);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(102, 20);
            this.txtMatricula.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(140, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 21);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Matricula";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(638, 789);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 91;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditar.Location = new System.Drawing.Point(720, 789);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 92;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(10, 12);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 23);
            this.btnVoltar.TabIndex = 97;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCpfPai
            // 
            this.txtCpfPai.Location = new System.Drawing.Point(62, 639);
            this.txtCpfPai.Mask = "000.000.000-00";
            this.txtCpfPai.Name = "txtCpfPai";
            this.txtCpfPai.Size = new System.Drawing.Size(235, 20);
            this.txtCpfPai.TabIndex = 126;
            // 
            // txtCpfMae
            // 
            this.txtCpfMae.Location = new System.Drawing.Point(458, 639);
            this.txtCpfMae.Mask = "000.000.000-00";
            this.txtCpfMae.Name = "txtCpfMae";
            this.txtCpfMae.Size = new System.Drawing.Size(241, 20);
            this.txtCpfMae.TabIndex = 128;
            // 
            // txtTelPai
            // 
            this.txtTelPai.Location = new System.Drawing.Point(62, 561);
            this.txtTelPai.Mask = "00 0.0000-0000";
            this.txtTelPai.Name = "txtTelPai";
            this.txtTelPai.Size = new System.Drawing.Size(235, 20);
            this.txtTelPai.TabIndex = 121;
            // 
            // txtTelMae
            // 
            this.txtTelMae.Location = new System.Drawing.Point(455, 558);
            this.txtTelMae.Mask = "00 0.0000-0000";
            this.txtTelMae.Name = "txtTelMae";
            this.txtTelMae.Size = new System.Drawing.Size(241, 20);
            this.txtTelMae.TabIndex = 122;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(455, 139);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(241, 20);
            this.txtCpf.TabIndex = 102;
            // 
            // celMask
            // 
            this.celMask.Location = new System.Drawing.Point(455, 217);
            this.celMask.Mask = "00 00000-0000";
            this.celMask.Name = "celMask";
            this.celMask.Size = new System.Drawing.Size(241, 20);
            this.celMask.TabIndex = 107;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(61, 584);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 142;
            this.label19.Text = "E-mail Pai";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(62, 375);
            this.txtNum.Mask = "00000000000";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(75, 20);
            this.txtNum.TabIndex = 114;
            this.txtNum.ValidatingType = typeof(int);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(458, 623);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 141;
            this.label29.Text = "CPF Mãe";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(59, 623);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 140;
            this.label28.Text = "CPF Pai";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(59, 673);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 139;
            this.label15.Text = "Principal Responsavel";
            // 
            // ckAmbos
            // 
            this.ckAmbos.AutoSize = true;
            this.ckAmbos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckAmbos.Location = new System.Drawing.Point(62, 735);
            this.ckAmbos.Name = "ckAmbos";
            this.ckAmbos.Size = new System.Drawing.Size(58, 17);
            this.ckAmbos.TabIndex = 132;
            this.ckAmbos.Text = "Ambos";
            this.ckAmbos.UseVisualStyleBackColor = true;
            // 
            // ckPai
            // 
            this.ckPai.AutoSize = true;
            this.ckPai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckPai.Location = new System.Drawing.Point(62, 712);
            this.ckPai.Name = "ckPai";
            this.ckPai.Size = new System.Drawing.Size(41, 17);
            this.ckPai.TabIndex = 131;
            this.ckPai.Text = "Pai";
            this.ckPai.UseVisualStyleBackColor = true;
            // 
            // ckMae
            // 
            this.ckMae.AutoSize = true;
            this.ckMae.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckMae.Location = new System.Drawing.Point(62, 689);
            this.ckMae.Name = "ckMae";
            this.ckMae.Size = new System.Drawing.Size(47, 17);
            this.ckMae.TabIndex = 129;
            this.ckMae.Text = "Mãe";
            this.ckMae.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(458, 584);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 138;
            this.label27.Text = "E-mail Mãe";
            // 
            // txtEmailMae
            // 
            this.txtEmailMae.Location = new System.Drawing.Point(458, 600);
            this.txtEmailMae.Name = "txtEmailMae";
            this.txtEmailMae.Size = new System.Drawing.Size(235, 20);
            this.txtEmailMae.TabIndex = 125;
            // 
            // txtEmailPai
            // 
            this.txtEmailPai.Location = new System.Drawing.Point(62, 600);
            this.txtEmailPai.Name = "txtEmailPai";
            this.txtEmailPai.Size = new System.Drawing.Size(235, 20);
            this.txtEmailPai.TabIndex = 124;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(458, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 137;
            this.label17.Text = "Celular Mãe";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(59, 542);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 136;
            this.label20.Text = "Celular Pai";
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(225, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(269, 36);
            this.label16.TabIndex = 135;
            this.label16.Text = "DADOS PAIS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(458, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 134;
            this.label14.Text = "Nome Mãe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(59, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 133;
            this.label18.Text = "Nome Pai";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(458, 519);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(235, 20);
            this.txtNomeMae.TabIndex = 120;
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(62, 519);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(235, 20);
            this.txtNomePai.TabIndex = 118;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RR",
            "RO",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(458, 378);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(74, 21);
            this.cbEstado.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(458, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(458, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 127;
            this.label12.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(458, 327);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(235, 20);
            this.txtCidade.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(277, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 36);
            this.label11.TabIndex = 123;
            this.label11.Text = "ENDEREÇO";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(455, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(63, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Data de Nascimento";
            // 
            // dtNascimento
            // 
            this.dtNascimento.CustomFormat = "DD/MM/AAAA";
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(62, 178);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(105, 20);
            this.dtNascimento.TabIndex = 103;
            this.dtNascimento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(62, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(59, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(62, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(62, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 113;
            this.label7.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(62, 414);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(235, 20);
            this.txtBairro.TabIndex = 117;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(62, 327);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(235, 20);
            this.txtRua.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 20);
            this.txtEmail.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(251, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 33);
            this.label4.TabIndex = 104;
            this.label4.Text = "DADOS PESSOAIS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(455, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(455, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "CPF";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(63, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 99;
            this.label21.Text = "Nome";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(455, 178);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(241, 20);
            this.txtRg.TabIndex = 105;
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(62, 139);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 98;
            // 
            // EditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 749);
            this.Controls.Add(this.txtCpfPai);
            this.Controls.Add(this.txtCpfMae);
            this.Controls.Add(this.txtTelPai);
            this.Controls.Add(this.txtTelMae);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.celMask);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ckAmbos);
            this.Controls.Add(this.ckPai);
            this.Controls.Add(this.ckMae);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtEmailMae);
            this.Controls.Add(this.txtEmailPai);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMatricula);
            this.Name = "EditarAluno";
            this.Text = "EditarAluno";
            this.Load += new System.EventHandler(this.EditarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox txtCpfPai;
        private System.Windows.Forms.MaskedTextBox txtCpfMae;
        private System.Windows.Forms.MaskedTextBox txtTelPai;
        private System.Windows.Forms.MaskedTextBox txtTelMae;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox celMask;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckAmbos;
        private System.Windows.Forms.CheckBox ckPai;
        private System.Windows.Forms.CheckBox ckMae;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtEmailMae;
        private System.Windows.Forms.TextBox txtEmailPai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
    }
}