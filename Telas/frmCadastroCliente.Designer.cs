namespace ProjetoCadastro
{
    partial class frmCadastroCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdClientes = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cboSitucao = new ComboBox();
            label15 = new Label();
            chkUtilizarOMesmo = new CheckBox();
            grpEnderecoEntrega = new GroupBox();
            txtCEPEntrega = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            txtUFEntrega = new TextBox();
            label12 = new Label();
            txtCidadeEntrega = new TextBox();
            label13 = new Label();
            txtBairroEntrega = new TextBox();
            label14 = new Label();
            txtEnderecoEntrega = new TextBox();
            txtCpfCnpj = new MaskedTextBox();
            label9 = new Label();
            rbJuridica = new RadioButton();
            rbFisica = new RadioButton();
            txtCEP = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            txtUF = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            txtNomeFantasia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRazaoSocial = new TextBox();
            txtCodigo = new TextBox();
            btnIncluir = new Button();
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            cboFiltroSituacao = new ComboBox();
            btnFiltrar = new Button();
            txtFiltro = new TextBox();
            cboFiltroPessoa = new ComboBox();
            cboTipoFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpEnderecoEntrega.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            grdClientes.AllowUserToResizeColumns = false;
            grdClientes.AllowUserToResizeRows = false;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Location = new Point(12, 71);
            grdClientes.MultiSelect = false;
            grdClientes.Name = "grdClientes";
            grdClientes.ReadOnly = true;
            grdClientes.RowHeadersVisible = false;
            grdClientes.ScrollBars = ScrollBars.Vertical;
            grdClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdClientes.Size = new Size(665, 150);
            grdClientes.TabIndex = 0;
            grdClientes.CellDoubleClick += grdClientes_CellDoubleClick;
            grdClientes.CellFormatting += grdClientes_CellFormatting;
            grdClientes.SelectionChanged += grdClientes_SelectionChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(12, 227);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(669, 301);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboSitucao);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(chkUtilizarOMesmo);
            tabPage1.Controls.Add(grpEnderecoEntrega);
            tabPage1.Controls.Add(txtCpfCnpj);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(rbJuridica);
            tabPage1.Controls.Add(rbFisica);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtUF);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtNomeFantasia);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtRazaoSocial);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(661, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboSitucao
            // 
            cboSitucao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSitucao.FormattingEnabled = true;
            cboSitucao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboSitucao.Location = new Point(566, 9);
            cboSitucao.Name = "cboSitucao";
            cboSitucao.Size = new Size(85, 23);
            cboSitucao.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(505, 12);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 23;
            label15.Text = "Situação:";
            // 
            // chkUtilizarOMesmo
            // 
            chkUtilizarOMesmo.AutoSize = true;
            chkUtilizarOMesmo.Location = new Point(12, 155);
            chkUtilizarOMesmo.Name = "chkUtilizarOMesmo";
            chkUtilizarOMesmo.Size = new Size(236, 19);
            chkUtilizarOMesmo.TabIndex = 22;
            chkUtilizarOMesmo.Text = "Utilizar o mesmo endereço para entrega";
            chkUtilizarOMesmo.UseVisualStyleBackColor = true;
            chkUtilizarOMesmo.CheckedChanged += chkUtilizarOMesmo_CheckedChanged;
            // 
            // grpEnderecoEntrega
            // 
            grpEnderecoEntrega.Controls.Add(txtCEPEntrega);
            grpEnderecoEntrega.Controls.Add(label10);
            grpEnderecoEntrega.Controls.Add(label11);
            grpEnderecoEntrega.Controls.Add(txtUFEntrega);
            grpEnderecoEntrega.Controls.Add(label12);
            grpEnderecoEntrega.Controls.Add(txtCidadeEntrega);
            grpEnderecoEntrega.Controls.Add(label13);
            grpEnderecoEntrega.Controls.Add(txtBairroEntrega);
            grpEnderecoEntrega.Controls.Add(label14);
            grpEnderecoEntrega.Controls.Add(txtEnderecoEntrega);
            grpEnderecoEntrega.Location = new Point(12, 179);
            grpEnderecoEntrega.Name = "grpEnderecoEntrega";
            grpEnderecoEntrega.Size = new Size(639, 87);
            grpEnderecoEntrega.TabIndex = 17;
            grpEnderecoEntrega.TabStop = false;
            grpEnderecoEntrega.Text = "Endereço Entrega";
            // 
            // txtCEPEntrega
            // 
            txtCEPEntrega.Location = new Point(565, 50);
            txtCEPEntrega.Mask = "00000-000";
            txtCEPEntrega.Name = "txtCEPEntrega";
            txtCEPEntrega.Size = new Size(60, 23);
            txtCEPEntrega.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(528, 53);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 25;
            label10.Text = "CEP:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(449, 53);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 24;
            label11.Text = "UF:";
            // 
            // txtUFEntrega
            // 
            txtUFEntrega.Location = new Point(479, 50);
            txtUFEntrega.MaxLength = 2;
            txtUFEntrega.Name = "txtUFEntrega";
            txtUFEntrega.Size = new Size(40, 23);
            txtUFEntrega.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(241, 53);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 22;
            label12.Text = "Cidade:";
            // 
            // txtCidadeEntrega
            // 
            txtCidadeEntrega.Location = new Point(294, 50);
            txtCidadeEntrega.Name = "txtCidadeEntrega";
            txtCidadeEntrega.Size = new Size(145, 23);
            txtCidadeEntrega.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 53);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 20;
            label13.Text = "Bairro:";
            // 
            // txtBairroEntrega
            // 
            txtBairroEntrega.Location = new Point(81, 50);
            txtBairroEntrega.Name = "txtBairroEntrega";
            txtBairroEntrega.Size = new Size(145, 23);
            txtBairroEntrega.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 24);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 18;
            label14.Text = "Endereço:";
            // 
            // txtEnderecoEntrega
            // 
            txtEnderecoEntrega.Location = new Point(81, 21);
            txtEnderecoEntrega.Name = "txtEnderecoEntrega";
            txtEnderecoEntrega.Size = new Size(544, 23);
            txtEnderecoEntrega.TabIndex = 9;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(377, 8);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(122, 23);
            txtCpfCnpj.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 12);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 19;
            label9.Text = "CPF/CNPJ:";
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(237, 11);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(65, 19);
            rbJuridica.TabIndex = 22;
            rbJuridica.TabStop = true;
            rbJuridica.Text = "Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            rbJuridica.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(177, 11);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(54, 19);
            rbFisica.TabIndex = 21;
            rbFisica.TabStop = true;
            rbFisica.Text = "Fisíca";
            rbFisica.UseVisualStyleBackColor = true;
            rbFisica.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(591, 125);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(60, 23);
            txtCEP.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(554, 128);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 15;
            label8.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 128);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "UF:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(502, 125);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(40, 23);
            txtUF.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 128);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(317, 125);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(145, 23);
            txtCidade.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(107, 125);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(145, 23);
            txtBairro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(107, 96);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(544, 23);
            txtEndereco.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(107, 67);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(544, 23);
            txtNomeFantasia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Razão Social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(107, 38);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(544, 23);
            txtRazaoSocial.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(107, 8);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(525, 534);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 2;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(606, 534);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboFiltroSituacao);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(cboFiltroPessoa);
            groupBox1.Controls.Add(cboTipoFiltro);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 57);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // cboFiltroSituacao
            // 
            cboFiltroSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroSituacao.FormattingEnabled = true;
            cboFiltroSituacao.Items.AddRange(new object[] { "Ambos", "Ativo", "Inativo" });
            cboFiltroSituacao.Location = new Point(107, 22);
            cboFiltroSituacao.Name = "cboFiltroSituacao";
            cboFiltroSituacao.Size = new Size(85, 23);
            cboFiltroSituacao.TabIndex = 29;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(580, 22);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 28;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(341, 22);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(234, 23);
            txtFiltro.TabIndex = 27;
            // 
            // cboFiltroPessoa
            // 
            cboFiltroPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroPessoa.FormattingEnabled = true;
            cboFiltroPessoa.Items.AddRange(new object[] { "Ambos", "Física", "Jurídica" });
            cboFiltroPessoa.Location = new Point(16, 22);
            cboFiltroPessoa.Name = "cboFiltroPessoa";
            cboFiltroPessoa.Size = new Size(85, 23);
            cboFiltroPessoa.TabIndex = 26;
            // 
            // cboTipoFiltro
            // 
            cboTipoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFiltro.FormattingEnabled = true;
            cboTipoFiltro.Items.AddRange(new object[] { "CPF/CNPJ", "Razão Social", "Nome Fantasia", "Endereço", "Cidade", "Endereço Entrega", "Cidade Entrega" });
            cboTipoFiltro.Location = new Point(198, 22);
            cboTipoFiltro.Name = "cboTipoFiltro";
            cboTipoFiltro.Size = new Size(137, 23);
            cboTipoFiltro.TabIndex = 25;
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 575);
            Controls.Add(groupBox1);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(grdClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grpEnderecoEntrega.ResumeLayout(false);
            grpEnderecoEntrega.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdClientes;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtRazaoSocial;
        private TextBox txtCodigo;
        private Button btnIncluir;
        private Button btnExcluir;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtNomeFantasia;
        private Label label8;
        private Label label7;
        private TextBox txtUF;
        private Label label6;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtEndereco;
        private MaskedTextBox txtCpfCnpj;
        private Label label9;
        private RadioButton rbJuridica;
        private RadioButton rbFisica;
        private MaskedTextBox txtCEP;
        private GroupBox grpEnderecoEntrega;
        private MaskedTextBox txtCEPEntrega;
        private Label label10;
        private Label label11;
        private TextBox txtUFEntrega;
        private Label label12;
        private TextBox txtCidadeEntrega;
        private Label label13;
        private TextBox txtBairroEntrega;
        private Label label14;
        private TextBox txtEnderecoEntrega;
        private CheckBox chkUtilizarOMesmo;
        private Label label15;
        private ComboBox cboSitucao;
        private GroupBox groupBox1;
        private ComboBox cboTipoFiltro;
        private ComboBox cboFiltroPessoa;
        private Button btnFiltrar;
        private TextBox txtFiltro;
        private ComboBox cboFiltroSituacao;
    }
}
