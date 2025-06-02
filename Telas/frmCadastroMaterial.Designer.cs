namespace ProjetoERP.Telas
{
    partial class frmCadastroMaterial
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
            grdMateriais = new DataGridView();
            btnExcluir = new Button();
            btnIncluir = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cboSitucao = new ComboBox();
            label15 = new Label();
            chkControlaEstoque = new CheckBox();
            label7 = new Label();
            txtUN = new TextBox();
            label3 = new Label();
            txtReferencia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtEstoqueAtual = new TextBox();
            label5 = new Label();
            txtValorVenda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdMateriais).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // grdMateriais
            // 
            grdMateriais.AllowUserToAddRows = false;
            grdMateriais.AllowUserToDeleteRows = false;
            grdMateriais.AllowUserToResizeColumns = false;
            grdMateriais.AllowUserToResizeRows = false;
            grdMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMateriais.Location = new Point(12, 12);
            grdMateriais.MultiSelect = false;
            grdMateriais.Name = "grdMateriais";
            grdMateriais.ReadOnly = true;
            grdMateriais.RowHeadersVisible = false;
            grdMateriais.ScrollBars = ScrollBars.Vertical;
            grdMateriais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMateriais.Size = new Size(665, 150);
            grdMateriais.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(606, 334);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(525, 334);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(12, 168);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(669, 160);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtValorVenda);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtEstoqueAtual);
            tabPage1.Controls.Add(cboSitucao);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(chkControlaEstoque);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtUN);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtReferencia);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(661, 132);
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
            label15.Location = new Point(508, 15);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 23;
            label15.Text = "Situação:";
            // 
            // chkControlaEstoque
            // 
            chkControlaEstoque.AutoSize = true;
            chkControlaEstoque.Location = new Point(15, 98);
            chkControlaEstoque.Name = "chkControlaEstoque";
            chkControlaEstoque.Size = new Size(122, 19);
            chkControlaEstoque.TabIndex = 22;
            chkControlaEstoque.Text = "Controla Estoque?";
            chkControlaEstoque.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 73);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 13;
            label7.Text = "UN:";
            // 
            // txtUN
            // 
            txtUN.Location = new Point(566, 67);
            txtUN.MaxLength = 2;
            txtUN.Name = "txtUN";
            txtUN.Size = new Size(85, 23);
            txtUN.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 73);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Referência:";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(107, 67);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(404, 23);
            txtReferencia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(107, 38);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(544, 23);
            txtDescricao.TabIndex = 2;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 99);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 26;
            label4.Text = "Estoque Atual:";
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.Enabled = false;
            txtEstoqueAtual.Location = new Point(242, 96);
            txtEstoqueAtual.MaxLength = 2;
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.Size = new Size(85, 23);
            txtEstoqueAtual.TabIndex = 25;
            txtEstoqueAtual.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 99);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 28;
            label5.Text = "Valor Venda:";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Enabled = false;
            txtValorVenda.Location = new Point(426, 96);
            txtValorVenda.MaxLength = 2;
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(85, 23);
            txtValorVenda.TabIndex = 27;
            txtValorVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // frmCadastroMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 364);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(grdMateriais);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroMaterial";
            ShowIcon = false;
            Text = "Material";
            ((System.ComponentModel.ISupportInitialize)grdMateriais).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdMateriais;
        private Button btnExcluir;
        private Button btnIncluir;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox cboSitucao;
        private Label label15;
        private CheckBox chkControlaEstoque;
        private Label label7;
        private TextBox txtUN;
        private Label label3;
        private TextBox txtReferencia;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private Label label5;
        private TextBox txtValorVenda;
        private Label label4;
        private TextBox txtEstoqueAtual;
    }
}