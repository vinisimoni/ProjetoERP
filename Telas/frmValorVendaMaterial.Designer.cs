namespace ProjetoERP.Telas
{
    partial class frmValorVendaMaterial
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
            btnLimpar = new Button();
            txtDescricaoMaterial = new TextBox();
            txtCodigoMaterial = new TextBox();
            btnSelecionaMaterial = new Button();
            grdValoresMaterial = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtValorNovo = new TextBox();
            label2 = new Label();
            txtValorAnterior = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnIncluir = new Button();
            ((System.ComponentModel.ISupportInitialize)grdValoresMaterial).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(117, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(31, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = ".";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtDescricaoMaterial
            // 
            txtDescricaoMaterial.BackColor = SystemColors.Window;
            txtDescricaoMaterial.Enabled = false;
            txtDescricaoMaterial.Location = new Point(154, 12);
            txtDescricaoMaterial.Name = "txtDescricaoMaterial";
            txtDescricaoMaterial.Size = new Size(528, 23);
            txtDescricaoMaterial.TabIndex = 11;
            // 
            // txtCodigoMaterial
            // 
            txtCodigoMaterial.BackColor = SystemColors.Window;
            txtCodigoMaterial.Enabled = false;
            txtCodigoMaterial.Location = new Point(12, 12);
            txtCodigoMaterial.Name = "txtCodigoMaterial";
            txtCodigoMaterial.Size = new Size(62, 23);
            txtCodigoMaterial.TabIndex = 10;
            txtCodigoMaterial.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSelecionaMaterial
            // 
            btnSelecionaMaterial.Location = new Point(80, 12);
            btnSelecionaMaterial.Name = "btnSelecionaMaterial";
            btnSelecionaMaterial.Size = new Size(31, 23);
            btnSelecionaMaterial.TabIndex = 9;
            btnSelecionaMaterial.Text = ".";
            btnSelecionaMaterial.UseVisualStyleBackColor = true;
            btnSelecionaMaterial.Click += btnSelecionaMaterial_Click;
            // 
            // grdValoresMaterial
            // 
            grdValoresMaterial.AllowUserToAddRows = false;
            grdValoresMaterial.AllowUserToDeleteRows = false;
            grdValoresMaterial.AllowUserToResizeColumns = false;
            grdValoresMaterial.AllowUserToResizeRows = false;
            grdValoresMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdValoresMaterial.Location = new Point(12, 41);
            grdValoresMaterial.MultiSelect = false;
            grdValoresMaterial.Name = "grdValoresMaterial";
            grdValoresMaterial.ReadOnly = true;
            grdValoresMaterial.RowHeadersVisible = false;
            grdValoresMaterial.ScrollBars = ScrollBars.Vertical;
            grdValoresMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdValoresMaterial.Size = new Size(452, 265);
            grdValoresMaterial.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(470, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(216, 99);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtValorNovo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtValorAnterior);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(208, 71);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtValorNovo
            // 
            txtValorNovo.Location = new Point(96, 38);
            txtValorNovo.Name = "txtValorNovo";
            txtValorNovo.Size = new Size(100, 23);
            txtValorNovo.TabIndex = 3;
            txtValorNovo.TextAlign = HorizontalAlignment.Right;
            txtValorNovo.KeyPress += txtValorNovo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 41);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor Novo:";
            // 
            // txtValorAnterior
            // 
            txtValorAnterior.Enabled = false;
            txtValorAnterior.Location = new Point(96, 9);
            txtValorAnterior.Name = "txtValorAnterior";
            txtValorAnterior.Size = new Size(100, 23);
            txtValorAnterior.TabIndex = 1;
            txtValorAnterior.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor Anterior:";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(607, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(526, 146);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 15;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // frmValorVendaMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 319);
            Controls.Add(btnIncluir);
            Controls.Add(btnCancelar);
            Controls.Add(tabControl1);
            Controls.Add(btnLimpar);
            Controls.Add(txtDescricaoMaterial);
            Controls.Add(txtCodigoMaterial);
            Controls.Add(btnSelecionaMaterial);
            Controls.Add(grdValoresMaterial);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmValorVendaMaterial";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valor Venda Material";
            ((System.ComponentModel.ISupportInitialize)grdValoresMaterial).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private TextBox txtDescricaoMaterial;
        private TextBox txtCodigoMaterial;
        private Button btnSelecionaMaterial;
        private DataGridView grdValoresMaterial;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtValorNovo;
        private Label label2;
        private TextBox txtValorAnterior;
        private Label label1;
        private Button btnCancelar;
        private Button btnIncluir;
    }
}