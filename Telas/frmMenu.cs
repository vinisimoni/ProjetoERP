using ProjetoCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP.Telas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            frmCadastroCliente tela = new frmCadastroCliente();
            tela.ShowDialog(this);
        }

        private void btnCadMateriais_Click(object sender, EventArgs e)
        {
            frmCadastroMaterial tela = new frmCadastroMaterial();
            tela.ShowDialog(this);
        }

        private void btnValorVenda_Click(object sender, EventArgs e)
        {
            frmValorVendaMaterial tela = new frmValorVendaMaterial();
            tela.ShowDialog(this);
        }

        private void btnLancEstoque_Click(object sender, EventArgs e)
        {
            frmEntradaSaidaEstoque tela = new frmEntradaSaidaEstoque();
            tela.ShowDialog(this);
        }
    }
}
