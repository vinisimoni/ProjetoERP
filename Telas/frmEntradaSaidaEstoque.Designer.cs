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
            grdMateriais = new DataGridView();
            grdMovMateriais = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdMateriais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdMovMateriais).BeginInit();
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
            grdMateriais.TabIndex = 2;
            grdMateriais.CellDoubleClick += grdMateriais_CellDoubleClick;
            // 
            // grdMovMateriais
            // 
            grdMovMateriais.AllowUserToAddRows = false;
            grdMovMateriais.AllowUserToDeleteRows = false;
            grdMovMateriais.AllowUserToResizeColumns = false;
            grdMovMateriais.AllowUserToResizeRows = false;
            grdMovMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMovMateriais.Location = new Point(12, 168);
            grdMovMateriais.MultiSelect = false;
            grdMovMateriais.Name = "grdMovMateriais";
            grdMovMateriais.ReadOnly = true;
            grdMovMateriais.RowHeadersVisible = false;
            grdMovMateriais.ScrollBars = ScrollBars.Vertical;
            grdMovMateriais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMovMateriais.Size = new Size(665, 150);
            grdMovMateriais.TabIndex = 3;
            // 
            // frmEntradaSaidaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdMovMateriais);
            Controls.Add(grdMateriais);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntradaSaidaEstoque";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada e Saída de Estoque";
            ((System.ComponentModel.ISupportInitialize)grdMateriais).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdMovMateriais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdMateriais;
        private DataGridView grdMovMateriais;
    }
}