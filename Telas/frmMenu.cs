using ProjetoCadastro;

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

        private void btnCadContas_Click(object sender, EventArgs e)
        {
            frmCadastroConta tela = new frmCadastroConta();
            tela.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroFormaPagamento tela = new frmCadastroFormaPagamento();
            tela.ShowDialog(this);
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor tela = new frmCadastroFornecedor();
            tela.ShowDialog(this);
        }
    }
}
