namespace Controle_de_Vendas.br.com.controlevendas.VIEW
{
    partial class FrmClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCEP = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 157);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(-1, 164);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(1143, 361);
            this.tabClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCEP);
            this.tabPage1.Controls.Add(this.cbUF);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.mskCEP);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.mskCelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.mskTelefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.mskCPF);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.mskRG);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1135, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(834, 26);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(106, 29);
            this.btnCEP.TabIndex = 8;
            this.btnCEP.Text = "Consultar";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
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
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(685, 177);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(145, 29);
            this.cbUF.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(635, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 22);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(685, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(145, 27);
            this.txtCidade.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(592, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(945, 123);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(145, 27);
            this.txtBairro.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(860, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro: ";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(685, 225);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(145, 27);
            this.txtComplemento.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(524, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Complemento: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(945, 160);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 27);
            this.txtNumero.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(847, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Numero: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(685, 75);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(394, 27);
            this.txtEndereco.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(568, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço: ";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(688, 26);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(135, 27);
            this.mskCEP.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(621, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCliente);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1135, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(8, 72);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 49;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(1119, 243);
            this.dgvCliente.TabIndex = 7;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(482, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(132, 40);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(92, 22);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(371, 29);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(14, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 22);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome: ";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(284, 542);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 47);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(422, 542);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 47);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(698, 542);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 47);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(560, 542);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 47);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(33, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(42, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(303, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG: ";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(361, 165);
            this.mskRG.Mask = "##,###,###";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(120, 27);
            this.mskRG.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(297, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF: ";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(361, 209);
            this.mskCPF.Mask = "###,###,###-##";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(120, 27);
            this.mskCPF.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone: ";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(114, 160);
            this.mskTelefone.Mask = "(99) 9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(135, 27);
            this.mskTelefone.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(19, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular: ";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(114, 210);
            this.mskCelular.Mask = "(99) 9 9999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(135, 27);
            this.mskCelular.TabIndex = 4;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 613);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
    }
}