namespace ProjetoERP.Telas.Seleciona
{
    partial class frmSelecionaConta
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
            btnSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdContas).BeginInit();
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
            grdContas.TabIndex = 4;
            grdContas.CellDoubleClick += grdContas_CellDoubleClick;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(299, 198);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 5;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // frmSelecionaConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 231);
            Controls.Add(btnSelecionar);
            Controls.Add(grdContas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSelecionaConta";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleciona Conta";
            Load += frmSelecionaConta_Load;
            ((System.ComponentModel.ISupportInitialize)grdContas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdContas;
        private Button btnSelecionar;
    }
}