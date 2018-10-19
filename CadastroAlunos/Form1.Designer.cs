namespace CadastroAlunos
{
    partial class Form1
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textRG = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.textNumCasa = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelSistCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(106, 62);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(621, 20);
            this.textNome.TabIndex = 0;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(106, 107);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(158, 20);
            this.textRG.TabIndex = 1;
            this.textRG.TextChanged += new System.EventHandler(this.textRG_TextChanged);
            // 
            // textRua
            // 
            this.textRua.Location = new System.Drawing.Point(106, 156);
            this.textRua.Name = "textRua";
            this.textRua.Size = new System.Drawing.Size(621, 20);
            this.textRua.TabIndex = 3;
            this.textRua.TextChanged += new System.EventHandler(this.textRua_TextChanged);
            // 
            // textNumCasa
            // 
            this.textNumCasa.Location = new System.Drawing.Point(106, 204);
            this.textNumCasa.Name = "textNumCasa";
            this.textNumCasa.Size = new System.Drawing.Size(100, 20);
            this.textNumCasa.TabIndex = 4;
            this.textNumCasa.TextChanged += new System.EventHandler(this.textNumCasa_TextChanged);
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(331, 204);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(396, 20);
            this.textBairro.TabIndex = 5;
            this.textBairro.TextChanged += new System.EventHandler(this.textBairro_TextChanged);
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(106, 250);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(219, 20);
            this.textCidade.TabIndex = 6;
            this.textCidade.TextChanged += new System.EventHandler(this.textCidade_TextChanged);
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(506, 107);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCPF.TabIndex = 28;
            this.maskedTextBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPF_MaskInputRejected_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "RG";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(460, 107);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(40, 20);
            this.labelCPF.TabIndex = 11;
            this.labelCPF.Text = "CPF";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRua.Location = new System.Drawing.Point(61, 154);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(39, 20);
            this.labelRua.TabIndex = 12;
            this.labelRua.Text = "Rua";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(74, 204);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(26, 20);
            this.labelNum.TabIndex = 13;
            this.labelNum.Text = "Nº";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(274, 202);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(51, 20);
            this.labelBairro.TabIndex = 14;
            this.labelBairro.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cidade";
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "SP",
            "BH",
            "SC"});
            this.comboBoxUF.Location = new System.Drawing.Point(445, 250);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(41, 21);
            this.comboBoxUF.TabIndex = 16;
            this.comboBoxUF.SelectedIndexChanged += new System.EventHandler(this.comboBoxUF_SelectedIndexChanged);
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.Location = new System.Drawing.Point(565, 250);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(41, 20);
            this.labelCEP.TabIndex = 18;
            this.labelCEP.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(612, 249);
            this.maskedTextBoxCEP.Mask = "00.000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBoxCEP.TabIndex = 17;
            this.maskedTextBoxCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.Location = new System.Drawing.Point(408, 251);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(31, 20);
            this.labelUF.TabIndex = 19;
            this.labelUF.Text = "UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Curso";
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Items.AddRange(new object[] {
            "DESENVOLVIMENTO DE SISTEMAS",
            "RECURSOS HUMANOS",
            "ENFERMAGEM"});
            this.comboBoxCurso.Location = new System.Drawing.Point(106, 294);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(196, 21);
            this.comboBoxCurso.TabIndex = 20;
            this.comboBoxCurso.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Período";
            // 
            // comboBoxPeriodo
            // 
            this.comboBoxPeriodo.FormattingEnabled = true;
            this.comboBoxPeriodo.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE",
            "NOITE",
            "INTEGRAL"});
            this.comboBoxPeriodo.Location = new System.Drawing.Point(412, 296);
            this.comboBoxPeriodo.Name = "comboBoxPeriodo";
            this.comboBoxPeriodo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodo.TabIndex = 22;
            this.comboBoxPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ano";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(627, 296);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(100, 20);
            this.textBoxAno.TabIndex = 24;
            this.textBoxAno.TextChanged += new System.EventHandler(this.textBoxAno_TextChanged);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCadastrar.Location = new System.Drawing.Point(257, 372);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(85, 23);
            this.buttonCadastrar.TabIndex = 26;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.Location = new System.Drawing.Point(430, 372);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(85, 23);
            this.buttonLimpar.TabIndex = 27;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelSistCadastro
            // 
            this.labelSistCadastro.AutoSize = true;
            this.labelSistCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSistCadastro.Location = new System.Drawing.Point(190, 9);
            this.labelSistCadastro.Name = "labelSistCadastro";
            this.labelSistCadastro.Size = new System.Drawing.Size(380, 31);
            this.labelSistCadastro.TabIndex = 29;
            this.labelSistCadastro.Text = "Sistema de Cadastro de Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 402);
            this.Controls.Add(this.labelSistCadastro);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.comboBoxUF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelRua);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textNumCasa);
            this.Controls.Add(this.textRua);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.textNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.TextBox textNumCasa;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelSistCadastro;
    }
}

