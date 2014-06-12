namespace WindowsFormsApplication3.Formularios
{
    partial class frm_cad_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_cliente));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_adicionarservico = new System.Windows.Forms.Button();
            this.btn_removerservico = new System.Windows.Forms.Button();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_operadora = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_operadora = new System.Windows.Forms.Label();
            this.lbl_numerocontato = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(9, 32);
            this.txt_nome.MaxLength = 100;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(260, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "MARIA TEREZINHA FERREIRA DA SILVA ALBINO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_endereco);
            this.groupBox1.Controls.Add(this.lbl_endereco);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.txt_cep);
            this.groupBox1.Controls.Add(this.txt_uf);
            this.groupBox1.Controls.Add(this.lbl_cep);
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Controls.Add(this.lbl_uf);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_cidade);
            this.groupBox1.Controls.Add(this.lbl_obs);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_cidade);
            this.groupBox1.Controls.Add(this.txt_bairro);
            this.groupBox1.Controls.Add(this.lbl_bairro);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_rg);
            this.groupBox1.Controls.Add(this.rb_cnpj);
            this.groupBox1.Controls.Add(this.rb_cpf);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Location = new System.Drawing.Point(82, 70);
            this.txt_endereco.MaxLength = 10;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(169, 20);
            this.txt_endereco.TabIndex = 5;
            this.txt_endereco.Text = "GOV. BENEDITO RUI BARBOSA";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(82, 55);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 4;
            this.lbl_endereco.Text = "Endereço";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(285, 70);
            this.txt_numero.MaxLength = 10;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(59, 20);
            this.txt_numero.TabIndex = 5;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(9, 109);
            this.txt_cep.MaxLength = 10;
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(59, 20);
            this.txt_cep.TabIndex = 5;
            this.txt_cep.Text = "95560-000";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(350, 109);
            this.txt_uf.MaxLength = 10;
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(25, 20);
            this.txt_uf.TabIndex = 5;
            this.txt_uf.Text = "RS";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(6, 93);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 4;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(285, 55);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(347, 93);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 4;
            this.lbl_uf.Text = "UF";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox2.Location = new System.Drawing.Point(12, 187);
            this.textBox2.MaxLength = 10;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 62);
            this.textBox2.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Location = new System.Drawing.Point(9, 148);
            this.txt_email.MaxLength = 10;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(188, 20);
            this.txt_email.TabIndex = 5;
            this.txt_email.Text = "robsondasilvaalbino@hotmail.com";
            // 
            // txt_cidade
            // 
            this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cidade.Location = new System.Drawing.Point(191, 109);
            this.txt_cidade.MaxLength = 10;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(153, 20);
            this.txt_cidade.TabIndex = 5;
            this.txt_cidade.Text = "SÃO JOSE DOS AUSENTES";
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(9, 171);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(70, 13);
            this.lbl_obs.TabIndex = 4;
            this.lbl_obs.Text = "Observações";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(188, 93);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 4;
            this.lbl_cidade.Text = "Cidade";
            // 
            // txt_bairro
            // 
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.Location = new System.Drawing.Point(74, 109);
            this.txt_bairro.MaxLength = 10;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(111, 20);
            this.txt_bairro.TabIndex = 5;
            this.txt_bairro.Text = "SERTÃO DO PIRITU";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(71, 93);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 4;
            this.lbl_bairro.Text = "Bairro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 71);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "6088571812";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(6, 55);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(23, 13);
            this.lbl_rg.TabIndex = 4;
            this.lbl_rg.Text = "RG";
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Location = new System.Drawing.Point(320, 9);
            this.rb_cnpj.Name = "rb_cnpj";
            this.rb_cnpj.Size = new System.Drawing.Size(52, 17);
            this.rb_cnpj.TabIndex = 3;
            this.rb_cnpj.Text = "CNPJ";
            this.rb_cnpj.UseVisualStyleBackColor = true;
            this.rb_cnpj.CheckedChanged += new System.EventHandler(this.rb_cnpj_CheckedChanged);
            // 
            // rb_cpf
            // 
            this.rb_cpf.AutoSize = true;
            this.rb_cpf.Checked = true;
            this.rb_cpf.Location = new System.Drawing.Point(275, 9);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_cpf.TabIndex = 3;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            this.rb_cpf.CheckedChanged += new System.EventHandler(this.rb_cpf_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(275, 32);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(108, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Text = "01838095055";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_adicionarservico);
            this.groupBox2.Controls.Add(this.btn_removerservico);
            this.groupBox2.Controls.Add(this.cb_tipo);
            this.groupBox2.Controls.Add(this.cb_operadora);
            this.groupBox2.Controls.Add(this.lbl_tipo);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lbl_operadora);
            this.groupBox2.Controls.Add(this.lbl_numerocontato);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // btn_adicionarservico
            // 
            this.btn_adicionarservico.FlatAppearance.BorderSize = 0;
            this.btn_adicionarservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarservico.Image = ((System.Drawing.Image)(resources.GetObject("btn_adicionarservico.Image")));
            this.btn_adicionarservico.Location = new System.Drawing.Point(313, 137);
            this.btn_adicionarservico.Name = "btn_adicionarservico";
            this.btn_adicionarservico.Size = new System.Drawing.Size(40, 40);
            this.btn_adicionarservico.TabIndex = 4;
            this.btn_adicionarservico.UseVisualStyleBackColor = true;
            // 
            // btn_removerservico
            // 
            this.btn_removerservico.FlatAppearance.BorderSize = 0;
            this.btn_removerservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removerservico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_removerservico.Image = ((System.Drawing.Image)(resources.GetObject("btn_removerservico.Image")));
            this.btn_removerservico.Location = new System.Drawing.Point(356, 137);
            this.btn_removerservico.Margin = new System.Windows.Forms.Padding(0);
            this.btn_removerservico.Name = "btn_removerservico";
            this.btn_removerservico.Size = new System.Drawing.Size(40, 40);
            this.btn_removerservico.TabIndex = 5;
            this.btn_removerservico.UseVisualStyleBackColor = true;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Particular",
            "Comercial"});
            this.cb_tipo.Location = new System.Drawing.Point(225, 109);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 3;
            // 
            // cb_operadora
            // 
            this.cb_operadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operadora.FormattingEnabled = true;
            this.cb_operadora.Items.AddRange(new object[] {
            "VIVO",
            "TIM",
            "CLARO",
            "OI"});
            this.cb_operadora.Location = new System.Drawing.Point(98, 109);
            this.cb_operadora.Name = "cb_operadora";
            this.cb_operadora.Size = new System.Drawing.Size(121, 21);
            this.cb_operadora.TabIndex = 3;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(222, 94);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Numero,
            this.operadora,
            this.tipo});
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(387, 75);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // operadora
            // 
            this.operadora.HeaderText = "operadora";
            this.operadora.Name = "operadora";
            this.operadora.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // lbl_operadora
            // 
            this.lbl_operadora.AutoSize = true;
            this.lbl_operadora.Location = new System.Drawing.Point(95, 94);
            this.lbl_operadora.Name = "lbl_operadora";
            this.lbl_operadora.Size = new System.Drawing.Size(57, 13);
            this.lbl_operadora.TabIndex = 0;
            this.lbl_operadora.Text = "Operadora";
            // 
            // lbl_numerocontato
            // 
            this.lbl_numerocontato.AutoSize = true;
            this.lbl_numerocontato.Location = new System.Drawing.Point(6, 94);
            this.lbl_numerocontato.Name = "lbl_numerocontato";
            this.lbl_numerocontato.Size = new System.Drawing.Size(44, 13);
            this.lbl_numerocontato.TabIndex = 0;
            this.lbl_numerocontato.Text = "Numero";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(9, 109);
            this.maskedTextBox2.Mask = "(99) 0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.Text = "5197598796";
            // 
            // btn_confirma
            // 
            this.btn_confirma.FlatAppearance.BorderSize = 0;
            this.btn_confirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirma.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirma.Image")));
            this.btn_confirma.Location = new System.Drawing.Point(669, 205);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(66, 66);
            this.btn_confirma.TabIndex = 10;
            this.btn_confirma.UseVisualStyleBackColor = true;
            // 
            // btn_cancela
            // 
            this.btn_cancela.FlatAppearance.BorderSize = 0;
            this.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancela.Image")));
            this.btn_cancela.Location = new System.Drawing.Point(750, 205);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(66, 66);
            this.btn_cancela.TabIndex = 9;
            this.btn_cancela.UseVisualStyleBackColor = true;
            // 
            // frm_cad_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 281);
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cad_cliente";
            this.Text = "frm_cad_cliente";
            this.Load += new System.EventHandler(this.frm_cad_cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_obs;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_numerocontato;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_operadora;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_operadora;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btn_adicionarservico;
        private System.Windows.Forms.Button btn_removerservico;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.Button btn_cancela;
    }
}