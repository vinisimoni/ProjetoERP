namespace ProjetoERP.Telas.Seleciona
{
    partial class frmSelecionaMaterial
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
            groupBox1 = new GroupBox();
            btnFiltrar = new Button();
            txtFiltro = new TextBox();
            cboFiltroTipo = new ComboBox();
            cboFiltroSituacao = new ComboBox();
            cboFiltroEstoque = new ComboBox();
            btnSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdMateriais).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grdMateriais
            // 
            grdMateriais.AllowUserToAddRows = false;
            grdMateriais.AllowUserToDeleteRows = false;
            grdMateriais.AllowUserToResizeColumns = false;
            grdMateriais.AllowUserToResizeRows = false;
            grdMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMateriais.Location = new Point(12, 77);
            grdMateriais.MultiSelect = false;
            grdMateriais.Name = "grdMateriais";
            grdMateriais.ReadOnly = true;
            grdMateriais.RowHeadersVisible = false;
            grdMateriais.ScrollBars = ScrollBars.Vertical;
            grdMateriais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMateriais.Size = new Size(704, 332);
            grdMateriais.TabIndex = 2;
            grdMateriais.CellDoubleClick += grdMateriais_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(cboFiltroTipo);
            groupBox1.Controls.Add(cboFiltroSituacao);
            groupBox1.Controls.Add(cboFiltroEstoque);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 59);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(613, 21);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(324, 22);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(283, 23);
            txtFiltro.TabIndex = 3;
            // 
            // cboFiltroTipo
            // 
            cboFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroTipo.FormattingEnabled = true;
            cboFiltroTipo.Items.AddRange(new object[] { "Descrição", "Referência" });
            cboFiltroTipo.Location = new Point(229, 22);
            cboFiltroTipo.Name = "cboFiltroTipo";
            cboFiltroTipo.Size = new Size(89, 23);
            cboFiltroTipo.TabIndex = 2;
            // 
            // cboFiltroSituacao
            // 
            cboFiltroSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroSituacao.FormattingEnabled = true;
            cboFiltroSituacao.Items.AddRange(new object[] { "Ambos", "Ativo", "Inativo" });
            cboFiltroSituacao.Location = new Point(134, 22);
            cboFiltroSituacao.Name = "cboFiltroSituacao";
            cboFiltroSituacao.Size = new Size(89, 23);
            cboFiltroSituacao.TabIndex = 1;
            // 
            // cboFiltroEstoque
            // 
            cboFiltroEstoque.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroEstoque.FormattingEnabled = true;
            cboFiltroEstoque.Items.AddRange(new object[] { "Ambos", "Com Estoque", "Sem Estoque" });
            cboFiltroEstoque.Location = new Point(18, 22);
            cboFiltroEstoque.Name = "cboFiltroEstoque";
            cboFiltroEstoque.Size = new Size(110, 23);
            cboFiltroEstoque.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(641, 415);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 4;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // frmSelecionaMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(btnSelecionar);
            Controls.Add(groupBox1);
            Controls.Add(grdMateriais);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSelecionaMaterial";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleciona Material";
            Load += frmSelecionaMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)grdMateriais).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdMateriais;
        private GroupBox groupBox1;
        private ComboBox cboFiltroEstoque;
        private ComboBox cboFiltroSituacao;
        private Button btnFiltrar;
        private TextBox txtFiltro;
        private ComboBox cboFiltroTipo;
        private Button btnSelecionar;
    }
}