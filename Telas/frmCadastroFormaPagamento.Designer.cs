namespace ProjetoERP.Telas
{
    partial class frmCadastroFormaPagamento
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
            grdFormasPgto = new DataGridView();
            btnExcluir = new Button();
            btnIncluir = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            btnLimpar = new Button();
            txtDescricaoConta = new TextBox();
            txtCodigoConta = new TextBox();
            btnSelecionaMaterial = new Button();
            chkPermitePagamento = new CheckBox();
            chkPermiteCompra = new CheckBox();
            chkPermiteRecebimento = new CheckBox();
            chkPermiteVenda = new CheckBox();
            chkAtualizarVencimentos = new CheckBox();
            label5 = new Label();
            txtDiasRecebimento = new TextBox();
            label4 = new Label();
            txtTaxaAdm = new TextBox();
            label3 = new Label();
            txtMaxParcelas = new TextBox();
            chkAVista = new CheckBox();
            cboSitucao = new ComboBox();
            label15 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            tbParcelas = new TabPage();
            label9 = new Label();
            txtNrParcela = new TextBox();
            btnIncluirParcela = new Button();
            label8 = new Label();
            txtDiasParcela = new TextBox();
            label7 = new Label();
            txtCodParcela = new TextBox();
            btnExcluirParcela = new Button();
            grdParcelas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdFormasPgto).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdParcelas).BeginInit();
            SuspendLayout();
            // 
            // grdFormasPgto
            // 
            grdFormasPgto.AllowUserToAddRows = false;
            grdFormasPgto.AllowUserToDeleteRows = false;
            grdFormasPgto.AllowUserToResizeColumns = false;
            grdFormasPgto.AllowUserToResizeRows = false;
            grdFormasPgto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFormasPgto.Location = new Point(12, 12);
            grdFormasPgto.MultiSelect = false;
            grdFormasPgto.Name = "grdFormasPgto";
            grdFormasPgto.ReadOnly = true;
            grdFormasPgto.RowHeadersVisible = false;
            grdFormasPgto.ScrollBars = ScrollBars.None;
            grdFormasPgto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdFormasPgto.Size = new Size(562, 180);
            grdFormasPgto.TabIndex = 4;
            grdFormasPgto.CellDoubleClick += grdFormasPgto_CellDoubleClick;
            grdFormasPgto.SelectionChanged += grdFormasPgto_SelectionChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(498, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(417, 415);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 10;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tbParcelas);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(12, 198);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(566, 211);
            tabControl1.TabIndex = 9;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnLimpar);
            tabPage1.Controls.Add(txtDescricaoConta);
            tabPage1.Controls.Add(txtCodigoConta);
            tabPage1.Controls.Add(btnSelecionaMaterial);
            tabPage1.Controls.Add(chkPermitePagamento);
            tabPage1.Controls.Add(chkPermiteCompra);
            tabPage1.Controls.Add(chkPermiteRecebimento);
            tabPage1.Controls.Add(chkPermiteVenda);
            tabPage1.Controls.Add(chkAtualizarVencimentos);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtDiasRecebimento);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtTaxaAdm);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtMaxParcelas);
            tabPage1.Controls.Add(chkAVista);
            tabPage1.Controls.Add(cboSitucao);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(558, 183);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 151);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 43;
            label6.Text = "Conta:";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(206, 147);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(31, 23);
            btnLimpar.TabIndex = 42;
            btnLimpar.Text = ".";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtDescricaoConta
            // 
            txtDescricaoConta.BackColor = SystemColors.Window;
            txtDescricaoConta.Enabled = false;
            txtDescricaoConta.Location = new Point(245, 147);
            txtDescricaoConta.Name = "txtDescricaoConta";
            txtDescricaoConta.Size = new Size(298, 23);
            txtDescricaoConta.TabIndex = 41;
            // 
            // txtCodigoConta
            // 
            txtCodigoConta.BackColor = SystemColors.Window;
            txtCodigoConta.Enabled = false;
            txtCodigoConta.Location = new Point(101, 147);
            txtCodigoConta.Name = "txtCodigoConta";
            txtCodigoConta.Size = new Size(62, 23);
            txtCodigoConta.TabIndex = 40;
            txtCodigoConta.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSelecionaMaterial
            // 
            btnSelecionaMaterial.Location = new Point(169, 147);
            btnSelecionaMaterial.Name = "btnSelecionaMaterial";
            btnSelecionaMaterial.Size = new Size(31, 23);
            btnSelecionaMaterial.TabIndex = 39;
            btnSelecionaMaterial.Text = ".";
            btnSelecionaMaterial.UseVisualStyleBackColor = true;
            btnSelecionaMaterial.Click += btnSelecionaMaterial_Click;
            // 
            // chkPermitePagamento
            // 
            chkPermitePagamento.AutoSize = true;
            chkPermitePagamento.Location = new Point(137, 122);
            chkPermitePagamento.Name = "chkPermitePagamento";
            chkPermitePagamento.Size = new Size(131, 19);
            chkPermitePagamento.TabIndex = 38;
            chkPermitePagamento.Text = "Permite Pagamento";
            chkPermitePagamento.UseVisualStyleBackColor = true;
            // 
            // chkPermiteCompra
            // 
            chkPermiteCompra.AutoSize = true;
            chkPermiteCompra.Location = new Point(13, 122);
            chkPermiteCompra.Name = "chkPermiteCompra";
            chkPermiteCompra.Size = new Size(113, 19);
            chkPermiteCompra.TabIndex = 37;
            chkPermiteCompra.Text = "Permite Compra";
            chkPermiteCompra.UseVisualStyleBackColor = true;
            // 
            // chkPermiteRecebimento
            // 
            chkPermiteRecebimento.AutoSize = true;
            chkPermiteRecebimento.Location = new Point(403, 97);
            chkPermiteRecebimento.Name = "chkPermiteRecebimento";
            chkPermiteRecebimento.Size = new Size(140, 19);
            chkPermiteRecebimento.TabIndex = 36;
            chkPermiteRecebimento.Text = "Permite Recebimento";
            chkPermiteRecebimento.UseVisualStyleBackColor = true;
            // 
            // chkPermiteVenda
            // 
            chkPermiteVenda.AutoSize = true;
            chkPermiteVenda.Location = new Point(274, 97);
            chkPermiteVenda.Name = "chkPermiteVenda";
            chkPermiteVenda.Size = new Size(102, 19);
            chkPermiteVenda.TabIndex = 35;
            chkPermiteVenda.Text = "Permite Venda";
            chkPermiteVenda.UseVisualStyleBackColor = true;
            // 
            // chkAtualizarVencimentos
            // 
            chkAtualizarVencimentos.AutoSize = true;
            chkAtualizarVencimentos.Location = new Point(101, 97);
            chkAtualizarVencimentos.Name = "chkAtualizarVencimentos";
            chkAtualizarVencimentos.Size = new Size(143, 19);
            chkAtualizarVencimentos.TabIndex = 34;
            chkAtualizarVencimentos.Text = "Atualizar Vencimentos";
            chkAtualizarVencimentos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 74);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 33;
            label5.Text = "Dias Recebimento:";
            // 
            // txtDiasRecebimento
            // 
            txtDiasRecebimento.Location = new Point(485, 71);
            txtDiasRecebimento.Name = "txtDiasRecebimento";
            txtDiasRecebimento.Size = new Size(58, 23);
            txtDiasRecebimento.TabIndex = 32;
            txtDiasRecebimento.TextAlign = HorizontalAlignment.Right;
            txtDiasRecebimento.KeyPress += txtDiasRecebimento_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 71);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 31;
            label4.Text = "Taxa Adm.:";
            // 
            // txtTaxaAdm
            // 
            txtTaxaAdm.Location = new Point(274, 68);
            txtTaxaAdm.Name = "txtTaxaAdm";
            txtTaxaAdm.Size = new Size(58, 23);
            txtTaxaAdm.TabIndex = 30;
            txtTaxaAdm.TextAlign = HorizontalAlignment.Right;
            txtTaxaAdm.KeyPress += txtTaxaAdm_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 29;
            label3.Text = "Máx. Parcelas:";
            // 
            // txtMaxParcelas
            // 
            txtMaxParcelas.Location = new Point(101, 68);
            txtMaxParcelas.Name = "txtMaxParcelas";
            txtMaxParcelas.Size = new Size(58, 23);
            txtMaxParcelas.TabIndex = 28;
            txtMaxParcelas.TextAlign = HorizontalAlignment.Right;
            txtMaxParcelas.KeyPress += txtMaxParcelas_KeyPress;
            // 
            // chkAVista
            // 
            chkAVista.AutoSize = true;
            chkAVista.Location = new Point(13, 97);
            chkAVista.Name = "chkAVista";
            chkAVista.Size = new Size(62, 19);
            chkAVista.TabIndex = 27;
            chkAVista.Text = "À Vista";
            chkAVista.UseVisualStyleBackColor = true;
            // 
            // cboSitucao
            // 
            cboSitucao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSitucao.FormattingEnabled = true;
            cboSitucao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboSitucao.Location = new Point(458, 8);
            cboSitucao.Name = "cboSitucao";
            cboSitucao.Size = new Size(85, 23);
            cboSitucao.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(397, 11);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 25;
            label15.Text = "Situação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Código:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(101, 39);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(442, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(101, 9);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 4;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // tbParcelas
            // 
            tbParcelas.Controls.Add(label9);
            tbParcelas.Controls.Add(txtNrParcela);
            tbParcelas.Controls.Add(btnIncluirParcela);
            tbParcelas.Controls.Add(label8);
            tbParcelas.Controls.Add(txtDiasParcela);
            tbParcelas.Controls.Add(label7);
            tbParcelas.Controls.Add(txtCodParcela);
            tbParcelas.Controls.Add(btnExcluirParcela);
            tbParcelas.Controls.Add(grdParcelas);
            tbParcelas.Location = new Point(4, 24);
            tbParcelas.Name = "tbParcelas";
            tbParcelas.Padding = new Padding(3);
            tbParcelas.Size = new Size(558, 183);
            tbParcelas.TabIndex = 1;
            tbParcelas.Text = "Parcelas";
            tbParcelas.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 47);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 19;
            label9.Text = "Nr. Parcela:";
            // 
            // txtNrParcela
            // 
            txtNrParcela.Enabled = false;
            txtNrParcela.Location = new Point(94, 44);
            txtNrParcela.Name = "txtNrParcela";
            txtNrParcela.Size = new Size(58, 23);
            txtNrParcela.TabIndex = 18;
            txtNrParcela.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIncluirParcela
            // 
            btnIncluirParcela.Location = new Point(77, 102);
            btnIncluirParcela.Name = "btnIncluirParcela";
            btnIncluirParcela.Size = new Size(75, 23);
            btnIncluirParcela.TabIndex = 17;
            btnIncluirParcela.Text = "Incluir";
            btnIncluirParcela.UseVisualStyleBackColor = true;
            btnIncluirParcela.Click += btnIncluirParcela_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 76);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 16;
            label8.Text = "Dias:";
            // 
            // txtDiasParcela
            // 
            txtDiasParcela.Location = new Point(94, 73);
            txtDiasParcela.Name = "txtDiasParcela";
            txtDiasParcela.Size = new Size(58, 23);
            txtDiasParcela.TabIndex = 15;
            txtDiasParcela.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 18);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 14;
            label7.Text = "Cód. Parcela:";
            // 
            // txtCodParcela
            // 
            txtCodParcela.Enabled = false;
            txtCodParcela.Location = new Point(94, 15);
            txtCodParcela.Name = "txtCodParcela";
            txtCodParcela.Size = new Size(58, 23);
            txtCodParcela.TabIndex = 13;
            txtCodParcela.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExcluirParcela
            // 
            btnExcluirParcela.Location = new Point(296, 157);
            btnExcluirParcela.Name = "btnExcluirParcela";
            btnExcluirParcela.Size = new Size(75, 23);
            btnExcluirParcela.TabIndex = 12;
            btnExcluirParcela.Text = "Excluir";
            btnExcluirParcela.UseVisualStyleBackColor = true;
            btnExcluirParcela.Click += btnExcluirParcela_Click;
            // 
            // grdParcelas
            // 
            grdParcelas.AllowUserToAddRows = false;
            grdParcelas.AllowUserToDeleteRows = false;
            grdParcelas.AllowUserToResizeColumns = false;
            grdParcelas.AllowUserToResizeRows = false;
            grdParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdParcelas.Location = new Point(158, 18);
            grdParcelas.MultiSelect = false;
            grdParcelas.Name = "grdParcelas";
            grdParcelas.ReadOnly = true;
            grdParcelas.RowHeadersVisible = false;
            grdParcelas.ScrollBars = ScrollBars.None;
            grdParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdParcelas.Size = new Size(213, 133);
            grdParcelas.TabIndex = 5;
            grdParcelas.CellDoubleClick += grdParcelas_CellDoubleClick;
            // 
            // frmCadastroFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 446);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(grdFormasPgto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroFormaPagamento";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formas de Pagamento";
            Load += frmCadastroFormaPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)grdFormasPgto).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tbParcelas.ResumeLayout(false);
            tbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdParcelas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdFormasPgto;
        private Button btnExcluir;
        private Button btnIncluir;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private ComboBox cboSitucao;
        private Label label15;
        private CheckBox chkAVista;
        private Label label4;
        private TextBox txtTaxaAdm;
        private Label label3;
        private TextBox txtMaxParcelas;
        private Label label5;
        private TextBox txtDiasRecebimento;
        private CheckBox chkAtualizarVencimentos;
        private CheckBox chkPermiteVenda;
        private CheckBox chkPermiteRecebimento;
        private CheckBox chkPermitePagamento;
        private CheckBox chkPermiteCompra;
        private Label label6;
        private Button btnLimpar;
        private TextBox txtDescricaoConta;
        private TextBox txtCodigoConta;
        private Button btnSelecionaMaterial;
        private TabPage tbParcelas;
        private DataGridView grdParcelas;
        private Button btnExcluirParcela;
        private Button btnIncluirParcela;
        private Label label8;
        private TextBox txtDiasParcela;
        private Label label7;
        private TextBox txtCodParcela;
        private Label label9;
        private TextBox txtNrParcela;
    }
}