namespace ProjetoERP.Telas
{
    partial class frmMenu
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
            btnCadClientes = new Button();
            btnCadMateriais = new Button();
            btnLancEstoque = new Button();
            btnValorVenda = new Button();
            btnCadContas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCadClientes
            // 
            btnCadClientes.Location = new Point(48, 22);
            btnCadClientes.Name = "btnCadClientes";
            btnCadClientes.Size = new Size(75, 23);
            btnCadClientes.TabIndex = 0;
            btnCadClientes.Text = "Clientes";
            btnCadClientes.UseVisualStyleBackColor = true;
            btnCadClientes.Click += btnCadClientes_Click;
            // 
            // btnCadMateriais
            // 
            btnCadMateriais.Location = new Point(48, 51);
            btnCadMateriais.Name = "btnCadMateriais";
            btnCadMateriais.Size = new Size(75, 23);
            btnCadMateriais.TabIndex = 1;
            btnCadMateriais.Text = "Materiais";
            btnCadMateriais.UseVisualStyleBackColor = true;
            btnCadMateriais.Click += btnCadMateriais_Click;
            // 
            // btnLancEstoque
            // 
            btnLancEstoque.Location = new Point(170, 22);
            btnLancEstoque.Name = "btnLancEstoque";
            btnLancEstoque.Size = new Size(85, 52);
            btnLancEstoque.TabIndex = 3;
            btnLancEstoque.Text = "Lançamento de Estoque";
            btnLancEstoque.UseVisualStyleBackColor = true;
            btnLancEstoque.Click += btnLancEstoque_Click;
            // 
            // btnValorVenda
            // 
            btnValorVenda.Location = new Point(170, 80);
            btnValorVenda.Name = "btnValorVenda";
            btnValorVenda.Size = new Size(85, 23);
            btnValorVenda.TabIndex = 4;
            btnValorVenda.Text = "Valor Venda";
            btnValorVenda.UseVisualStyleBackColor = true;
            btnValorVenda.Click += btnValorVenda_Click;
            // 
            // btnCadContas
            // 
            btnCadContas.Location = new Point(48, 80);
            btnCadContas.Name = "btnCadContas";
            btnCadContas.Size = new Size(75, 23);
            btnCadContas.TabIndex = 6;
            btnCadContas.Text = "Contas";
            btnCadContas.UseVisualStyleBackColor = true;
            btnCadContas.Click += btnCadContas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 109);
            button1.Name = "button1";
            button1.Size = new Size(85, 52);
            button1.TabIndex = 8;
            button1.Text = "Formas Recebimento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCadContas);
            Controls.Add(btnValorVenda);
            Controls.Add(btnLancEstoque);
            Controls.Add(btnCadMateriais);
            Controls.Add(btnCadClientes);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "frmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadClientes;
        private Button btnCadMateriais;
        private Button btnLancEstoque;
        private Button btnValorVenda;
        private Button btnCadContas;
        private Button button1;
    }
}