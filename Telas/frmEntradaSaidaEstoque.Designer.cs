namespace ProjetoERP.Telas
{
    partial class frmEntradaSaidaEstoque
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
            grdMovMateriais = new DataGridView();
            btnSelecionaMaterial = new Button();
            txtCodigoMaterial = new TextBox();
            txtDescricaoMaterial = new TextBox();
            btnLimpar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            txtQuantidade = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label1 = new Label();
            cboTipo = new ComboBox();
            btnIncluir = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdMovMateriais).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // grdMovMateriais
            // 
            grdMovMateriais.AllowUserToAddRows = false;
            grdMovMateriais.AllowUserToDeleteRows = false;
            grdMovMateriais.AllowUserToResizeColumns = false;
            grdMovMateriais.AllowUserToResizeRows = false;
            grdMovMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMovMateriais.Location = new Point(12, 41);
            grdMovMateriais.MultiSelect = false;
            grdMovMateriais.Name = "grdMovMateriais";
            grdMovMateriais.ReadOnly = true;
            grdMovMateriais.RowHeadersVisible = false;
            grdMovMateriais.ScrollBars = ScrollBars.Vertical;
            grdMovMateriais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMovMateriais.Size = new Size(665, 265);
            grdMovMateriais.TabIndex = 3;
            // 
            // btnSelecionaMaterial
            // 
            btnSelecionaMaterial.Location = new Point(80, 12);
            btnSelecionaMaterial.Name = "btnSelecionaMaterial";
            btnSelecionaMaterial.Size = new Size(31, 23);
            btnSelecionaMaterial.TabIndex = 4;
            btnSelecionaMaterial.Text = ".";
            btnSelecionaMaterial.UseVisualStyleBackColor = true;
            btnSelecionaMaterial.Click += btnSelecionaMaterial_Click;
            // 
            // txtCodigoMaterial
            // 
            txtCodigoMaterial.BackColor = SystemColors.Window;
            txtCodigoMaterial.Enabled = false;
            txtCodigoMaterial.Location = new Point(12, 12);
            txtCodigoMaterial.Name = "txtCodigoMaterial";
            txtCodigoMaterial.Size = new Size(62, 23);
            txtCodigoMaterial.TabIndex = 5;
            txtCodigoMaterial.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescricaoMaterial
            // 
            txtDescricaoMaterial.BackColor = SystemColors.Window;
            txtDescricaoMaterial.Enabled = false;
            txtDescricaoMaterial.Location = new Point(154, 12);
            txtDescricaoMaterial.Name = "txtDescricaoMaterial";
            txtDescricaoMaterial.Size = new Size(523, 23);
            txtDescricaoMaterial.TabIndex = 6;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(117, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(31, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = ".";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(13, 312);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(664, 104);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtQuantidade);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cboTipo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 76);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 14);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(292, 10);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(121, 23);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(73, 40);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(570, 23);
            txtDescricao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo:";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Entrada", "Saída" });
            cboTipo.Location = new Point(73, 11);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 0;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(517, 418);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 9;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(598, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmEntradaSaidaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(btnLimpar);
            Controls.Add(txtDescricaoMaterial);
            Controls.Add(txtCodigoMaterial);
            Controls.Add(btnSelecionaMaterial);
            Controls.Add(grdMovMateriais);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntradaSaidaEstoque";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada e Saída de Estoque";
            ((System.ComponentModel.ISupportInitialize)grdMovMateriais).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdMovMateriais;
        private Button btnSelecionaMaterial;
        private TextBox txtCodigoMaterial;
        private TextBox txtDescricaoMaterial;
        private Button btnLimpar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox cboTipo;
        private Label label3;
        private TextBox txtQuantidade;
        private Label label2;
        private TextBox txtDescricao;
        private Label label1;
        private Button btnIncluir;
        private Button btnCancelar;
    }
}