namespace ProjetoERP.Telas
{
    partial class frmCadastroConta
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
            grdContas = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            btnExcluir = new Button();
            btnIncluir = new Button();
            ((System.ComponentModel.ISupportInitialize)grdContas).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // grdContas
            // 
            grdContas.AllowUserToAddRows = false;
            grdContas.AllowUserToDeleteRows = false;
            grdContas.AllowUserToResizeColumns = false;
            grdContas.AllowUserToResizeRows = false;
            grdContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContas.Location = new Point(12, 12);
            grdContas.MultiSelect = false;
            grdContas.Name = "grdContas";
            grdContas.ReadOnly = true;
            grdContas.RowHeadersVisible = false;
            grdContas.ScrollBars = ScrollBars.Vertical;
            grdContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContas.Size = new Size(363, 180);
            grdContas.TabIndex = 3;
            grdContas.CellDoubleClick += grdContas_CellDoubleClick;
            grdContas.SelectionChanged += grdContas_SelectionChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(12, 198);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(363, 100);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(355, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 43);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Código:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(84, 39);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(254, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(84, 9);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 4;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(296, 304);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(215, 304);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 7;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // frmCadastroConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 335);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(grdContas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroConta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contas";
            Load += frmCadastroConta_Load;
            ((System.ComponentModel.ISupportInitialize)grdContas).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdContas;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
    }
}