namespace WindowsFormsApplication3
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
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_defeito = new System.Windows.Forms.Label();
            this.txt_defeitocliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_previsãoentrega = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_numeroserie = new System.Windows.Forms.TextBox();
            this.lbl_numerodeserie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_estadoequipamento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_adicionarservico = new System.Windows.Forms.Button();
            this.btn_removerservico = new System.Windows.Forms.Button();
            this.btn_novoservico = new System.Windows.Forms.Button();
            this.cb_itemservico = new System.Windows.Forms.ComboBox();
            this.lbl_itemservico = new System.Windows.Forms.Label();
            this.dg_servico = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_adicionarpecas = new System.Windows.Forms.Button();
            this.btn_removerpecas = new System.Windows.Forms.Button();
            this.btn_novopecas = new System.Windows.Forms.Button();
            this.cb_pecas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_pecas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_defeitotecnico = new System.Windows.Forms.Label();
            this.txt_defeitotecnico = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_observacoes = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_servico)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pecas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(6, 16);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente ";
            // 
            // lbl_defeito
            // 
            this.lbl_defeito.AutoSize = true;
            this.lbl_defeito.Location = new System.Drawing.Point(6, 64);
            this.lbl_defeito.Name = "lbl_defeito";
            this.lbl_defeito.Size = new System.Drawing.Size(82, 13);
            this.lbl_defeito.TabIndex = 2;
            this.lbl_defeito.Text = "Defeito (Cliente)";
            // 
            // txt_defeitocliente
            // 
            this.txt_defeitocliente.Location = new System.Drawing.Point(9, 80);
            this.txt_defeitocliente.Multiline = true;
            this.txt_defeitocliente.Name = "txt_defeitocliente";
            this.txt_defeitocliente.Size = new System.Drawing.Size(427, 70);
            this.txt_defeitocliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbl_previsãoentrega);
            this.groupBox1.Controls.Add(this.lbl_cliente);
            this.groupBox1.Controls.Add(this.txt_defeitocliente);
            this.groupBox1.Controls.Add(this.lbl_defeito);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Cliente ";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(9, 33);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(219, 20);
            this.txt_cliente.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbl_previsãoentrega
            // 
            this.lbl_previsãoentrega.AutoSize = true;
            this.lbl_previsãoentrega.Location = new System.Drawing.Point(291, 16);
            this.lbl_previsãoentrega.Name = "lbl_previsãoentrega";
            this.lbl_previsãoentrega.Size = new System.Drawing.Size(88, 13);
            this.lbl_previsãoentrega.TabIndex = 4;
            this.lbl_previsãoentrega.Text = "Previsão Entrega";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_senha);
            this.groupBox2.Controls.Add(this.txt_senha);
            this.groupBox2.Controls.Add(this.lbl_modelo);
            this.groupBox2.Controls.Add(this.txt_modelo);
            this.groupBox2.Controls.Add(this.txt_numeroserie);
            this.groupBox2.Controls.Add(this.lbl_numerodeserie);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbl_estadoequipamento);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Equipamento";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(320, 102);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(323, 118);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(113, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(164, 102);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 4;
            this.lbl_modelo.Text = "Modelo ";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(167, 118);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(149, 20);
            this.txt_modelo.TabIndex = 3;
            // 
            // txt_numeroserie
            // 
            this.txt_numeroserie.Location = new System.Drawing.Point(9, 118);
            this.txt_numeroserie.Name = "txt_numeroserie";
            this.txt_numeroserie.Size = new System.Drawing.Size(149, 20);
            this.txt_numeroserie.TabIndex = 3;
            // 
            // lbl_numerodeserie
            // 
            this.lbl_numerodeserie.AutoSize = true;
            this.lbl_numerodeserie.Location = new System.Drawing.Point(6, 102);
            this.lbl_numerodeserie.Name = "lbl_numerodeserie";
            this.lbl_numerodeserie.Size = new System.Drawing.Size(61, 13);
            this.lbl_numerodeserie.TabIndex = 2;
            this.lbl_numerodeserie.Text = "Nº de Série";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 67);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_estadoequipamento
            // 
            this.lbl_estadoequipamento.AutoSize = true;
            this.lbl_estadoequipamento.Location = new System.Drawing.Point(6, 16);
            this.lbl_estadoequipamento.Name = "lbl_estadoequipamento";
            this.lbl_estadoequipamento.Size = new System.Drawing.Size(105, 13);
            this.lbl_estadoequipamento.TabIndex = 0;
            this.lbl_estadoequipamento.Text = "Estado Equipamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_adicionarservico);
            this.groupBox3.Controls.Add(this.btn_removerservico);
            this.groupBox3.Controls.Add(this.btn_novoservico);
            this.groupBox3.Controls.Add(this.cb_itemservico);
            this.groupBox3.Controls.Add(this.lbl_itemservico);
            this.groupBox3.Controls.Add(this.dg_servico);
            this.groupBox3.Location = new System.Drawing.Point(479, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 173);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // btn_adicionarservico
            // 
            this.btn_adicionarservico.FlatAppearance.BorderSize = 0;
            this.btn_adicionarservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarservico.Image = global::WindowsFormsApplication3.Properties.imagens.adicionar_32x32;
            this.btn_adicionarservico.Location = new System.Drawing.Point(370, 113);
            this.btn_adicionarservico.Name = "btn_adicionarservico";
            this.btn_adicionarservico.Size = new System.Drawing.Size(40, 40);
            this.btn_adicionarservico.TabIndex = 3;
            this.btn_adicionarservico.UseVisualStyleBackColor = true;
            this.btn_adicionarservico.Click += new System.EventHandler(this.btn_adicionarservico_Click);
            // 
            // btn_removerservico
            // 
            this.btn_removerservico.FlatAppearance.BorderSize = 0;
            this.btn_removerservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removerservico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_removerservico.Image = global::WindowsFormsApplication3.Properties.imagens.remover_32x32;
            this.btn_removerservico.Location = new System.Drawing.Point(416, 113);
            this.btn_removerservico.Margin = new System.Windows.Forms.Padding(0);
            this.btn_removerservico.Name = "btn_removerservico";
            this.btn_removerservico.Size = new System.Drawing.Size(40, 40);
            this.btn_removerservico.TabIndex = 3;
            this.btn_removerservico.UseVisualStyleBackColor = true;
            // 
            // btn_novoservico
            // 
            this.btn_novoservico.Location = new System.Drawing.Point(328, 123);
            this.btn_novoservico.Name = "btn_novoservico";
            this.btn_novoservico.Size = new System.Drawing.Size(36, 23);
            this.btn_novoservico.TabIndex = 3;
            this.btn_novoservico.Text = "...";
            this.btn_novoservico.UseVisualStyleBackColor = true;
            // 
            // cb_itemservico
            // 
            this.cb_itemservico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_itemservico.FormattingEnabled = true;
            this.cb_itemservico.Location = new System.Drawing.Point(9, 124);
            this.cb_itemservico.Name = "cb_itemservico";
            this.cb_itemservico.Size = new System.Drawing.Size(315, 21);
            this.cb_itemservico.TabIndex = 2;
            // 
            // lbl_itemservico
            // 
            this.lbl_itemservico.AutoSize = true;
            this.lbl_itemservico.Location = new System.Drawing.Point(6, 108);
            this.lbl_itemservico.Name = "lbl_itemservico";
            this.lbl_itemservico.Size = new System.Drawing.Size(27, 13);
            this.lbl_itemservico.TabIndex = 1;
            this.lbl_itemservico.Text = "Item";
            // 
            // dg_servico
            // 
            this.dg_servico.AllowUserToAddRows = false;
            this.dg_servico.AllowUserToDeleteRows = false;
            this.dg_servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_servico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao});
            this.dg_servico.Location = new System.Drawing.Point(7, 20);
            this.dg_servico.Name = "dg_servico";
            this.dg_servico.ReadOnly = true;
            this.dg_servico.RowHeadersVisible = false;
            this.dg_servico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_servico.Size = new System.Drawing.Size(497, 85);
            this.dg_servico.TabIndex = 0;
            this.dg_servico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_servico_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_adicionarpecas);
            this.groupBox4.Controls.Add(this.btn_removerpecas);
            this.groupBox4.Controls.Add(this.btn_novopecas);
            this.groupBox4.Controls.Add(this.cb_pecas);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dg_pecas);
            this.groupBox4.Location = new System.Drawing.Point(479, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 164);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Peças";
            // 
            // btn_adicionarpecas
            // 
            this.btn_adicionarpecas.FlatAppearance.BorderSize = 0;
            this.btn_adicionarpecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarpecas.Image = global::WindowsFormsApplication3.Properties.imagens.adicionar_32x32;
            this.btn_adicionarpecas.Location = new System.Drawing.Point(370, 113);
            this.btn_adicionarpecas.Name = "btn_adicionarpecas";
            this.btn_adicionarpecas.Size = new System.Drawing.Size(40, 40);
            this.btn_adicionarpecas.TabIndex = 3;
            this.btn_adicionarpecas.UseVisualStyleBackColor = true;
            // 
            // btn_removerpecas
            // 
            this.btn_removerpecas.FlatAppearance.BorderSize = 0;
            this.btn_removerpecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removerpecas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_removerpecas.Image = global::WindowsFormsApplication3.Properties.imagens.remover_32x32;
            this.btn_removerpecas.Location = new System.Drawing.Point(416, 113);
            this.btn_removerpecas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_removerpecas.Name = "btn_removerpecas";
            this.btn_removerpecas.Size = new System.Drawing.Size(40, 40);
            this.btn_removerpecas.TabIndex = 3;
            this.btn_removerpecas.UseVisualStyleBackColor = true;
            // 
            // btn_novopecas
            // 
            this.btn_novopecas.Location = new System.Drawing.Point(328, 123);
            this.btn_novopecas.Name = "btn_novopecas";
            this.btn_novopecas.Size = new System.Drawing.Size(36, 23);
            this.btn_novopecas.TabIndex = 3;
            this.btn_novopecas.Text = "...";
            this.btn_novopecas.UseVisualStyleBackColor = true;
            // 
            // cb_pecas
            // 
            this.cb_pecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pecas.FormattingEnabled = true;
            this.cb_pecas.Location = new System.Drawing.Point(9, 124);
            this.cb_pecas.Name = "cb_pecas";
            this.cb_pecas.Size = new System.Drawing.Size(315, 21);
            this.cb_pecas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // dg_pecas
            // 
            this.dg_pecas.AllowUserToAddRows = false;
            this.dg_pecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dg_pecas.Location = new System.Drawing.Point(7, 20);
            this.dg_pecas.Name = "dg_pecas";
            this.dg_pecas.RowHeadersVisible = false;
            this.dg_pecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pecas.Size = new System.Drawing.Size(497, 85);
            this.dg_pecas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btn_cancela
            // 
            this.btn_cancela.FlatAppearance.BorderSize = 0;
            this.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela.Image = global::WindowsFormsApplication3.Properties.imagens.cancelar_64x64;
            this.btn_cancela.Location = new System.Drawing.Point(914, 398);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(66, 66);
            this.btn_cancela.TabIndex = 7;
            this.btn_cancela.UseVisualStyleBackColor = true;
            // 
            // btn_confirma
            // 
            this.btn_confirma.FlatAppearance.BorderSize = 0;
            this.btn_confirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirma.Image = global::WindowsFormsApplication3.Properties.imagens.confirmar_64x64;
            this.btn_confirma.Location = new System.Drawing.Point(833, 398);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(66, 66);
            this.btn_confirma.TabIndex = 8;
            this.btn_confirma.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_defeitotecnico);
            this.groupBox5.Controls.Add(this.txt_defeitotecnico);
            this.groupBox5.Location = new System.Drawing.Point(12, 361);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 110);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informações Técnico";
            // 
            // lbl_defeitotecnico
            // 
            this.lbl_defeitotecnico.AutoSize = true;
            this.lbl_defeitotecnico.Location = new System.Drawing.Point(6, 16);
            this.lbl_defeitotecnico.Name = "lbl_defeitotecnico";
            this.lbl_defeitotecnico.Size = new System.Drawing.Size(83, 13);
            this.lbl_defeitotecnico.TabIndex = 2;
            this.lbl_defeitotecnico.Text = "Defeito (Ténico)";
            // 
            // txt_defeitotecnico
            // 
            this.txt_defeitotecnico.Location = new System.Drawing.Point(9, 32);
            this.txt_defeitotecnico.Multiline = true;
            this.txt_defeitotecnico.Name = "txt_defeitotecnico";
            this.txt_defeitotecnico.Size = new System.Drawing.Size(427, 70);
            this.txt_defeitotecnico.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_observacoes);
            this.groupBox6.Controls.Add(this.txt_obs);
            this.groupBox6.Location = new System.Drawing.Point(479, 361);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 110);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "informações Adicionais";
            // 
            // lbl_observacoes
            // 
            this.lbl_observacoes.AutoSize = true;
            this.lbl_observacoes.Location = new System.Drawing.Point(6, 16);
            this.lbl_observacoes.Name = "lbl_observacoes";
            this.lbl_observacoes.Size = new System.Drawing.Size(70, 13);
            this.lbl_observacoes.TabIndex = 2;
            this.lbl_observacoes.Text = "Observações";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(9, 32);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(324, 70);
            this.txt_obs.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 483);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastro de O.S.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_servico)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pecas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_defeito;
        private System.Windows.Forms.TextBox txt_defeitocliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_previsãoentrega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_numeroserie;
        private System.Windows.Forms.Label lbl_numerodeserie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_estadoequipamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_servico;
        private System.Windows.Forms.Button btn_adicionarservico;
        private System.Windows.Forms.Button btn_novoservico;
        private System.Windows.Forms.ComboBox cb_itemservico;
        private System.Windows.Forms.Label lbl_itemservico;
        private System.Windows.Forms.Button btn_removerservico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_adicionarpecas;
        private System.Windows.Forms.Button btn_removerpecas;
        private System.Windows.Forms.Button btn_novopecas;
        private System.Windows.Forms.ComboBox cb_pecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_pecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_defeitotecnico;
        private System.Windows.Forms.TextBox txt_defeitotecnico;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_observacoes;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button button1;

    }
}

