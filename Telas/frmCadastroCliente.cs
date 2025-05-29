using ProjetoCadastro.Domain;
using ProjetoCadastro.Domain.Enums;
using ProjetoCadastro.Repositories;
using ProjetoCadastro.ViewModels;

namespace ProjetoCadastro
{
    public partial class frmCadastroCliente : Form
    {

        private ClienteViewModel _clienteVm = new ClienteViewModel();
        private ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();

        public frmCadastroCliente()
        {
            InitializeComponent();
            AtualizarBotaoExcluir();
            ConfigurarDataBindings();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (btnIncluir.Text == "Incluir")
            {
                tabControl1.Enabled = true;
                btnIncluir.Text = "OK";
                btnExcluir.Text = "Cancelar";
                btnExcluir.Enabled = true;
                grdClientes.Enabled = false;
                rbFisica.Checked = true;
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                txtCpfCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _clienteVm.CpfCnpj = txtCpfCnpj.Text;

                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _clienteVm.Cep = txtCEP.Text;

                txtCEPEntrega.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _clienteVm.CepEntrega = txtCEPEntrega.Text;

                Cliente cliente = _clienteVm.ToEntity();

                _clienteRepositorio.Incluir(cliente);

                LimparFormulario();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (btnExcluir.Text == "Excluir")
            {

            }
            else
            {
                LimparFormulario();
            }
        }

        private void LimparFormulario()
        {
            grdClientes.Enabled = true;
            tabControl1.Enabled = false;
            rbFisica.Checked = true;
            chkUtilizarOMesmo.Checked = false;
            btnIncluir.Text = "Incluir";
            btnExcluir.Text = "Excluir";
            LimparCampos();
            AtualizarBotaoExcluir();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCpfCnpj.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtEnderecoEntrega.Text = string.Empty;
            txtBairroEntrega.Text = string.Empty;
            txtCidadeEntrega.Text = string.Empty;
            txtUFEntrega.Text = string.Empty;
            txtCEPEntrega.Text = string.Empty;
        }

        private void AtualizarBotaoExcluir()
        {
            bool temLinha = grdClientes.Rows.Count > 0;
            bool linhaSelecionada = grdClientes.CurrentRow != null && grdClientes.CurrentRow.Index >= 0;

            btnExcluir.Enabled = temLinha && linhaSelecionada;
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
        }

        private bool ValidarCampos()
        {
            if (!txtCpfCnpj.MaskFull)
            {
                MessageBox.Show("O campo CPF/CNPJ é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpfCnpj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
            {
                MessageBox.Show("O campo Razão Social é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazaoSocial.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("O campo Endereço é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("O campo Bairro é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("O campo Cidade é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUF.Text))
            {
                MessageBox.Show("O campo UF é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUF.Focus();
                return false;
            }

            if (!txtCEP.MaskFull)
            {
                MessageBox.Show("O campo CEP é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEnderecoEntrega.Text))
            {
                MessageBox.Show("O campo Endereço Entrega é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoEntrega.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairroEntrega.Text))
            {
                MessageBox.Show("O campo Bairro Entrega é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairroEntrega.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidadeEntrega.Text))
            {
                MessageBox.Show("O campo Cidade Entrega é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidadeEntrega.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUFEntrega.Text))
            {
                MessageBox.Show("O campo UF Entrega é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUFEntrega.Focus();
                return false;
            }

            if (!txtCEPEntrega.MaskFull)
            {
                MessageBox.Show("O campo CEP Entrega é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEPEntrega.Focus();
                return false;
            }

            return true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                txtCpfCnpj.Mask = "000.000.000-00";
                txtCpfCnpj.Clear();
                _clienteVm.TipoPessoa = ETipoPessoa.Fisica;
            }
            else if (rbJuridica.Checked)
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
                txtCpfCnpj.Clear();
                _clienteVm.TipoPessoa = ETipoPessoa.Juridica;
            }
        }

        private void chkUtilizarOMesmo_CheckedChanged(object sender, EventArgs e)
        {
            this.Validate();

            if (chkUtilizarOMesmo.Checked)
            {
                grpEnderecoEntrega.Enabled = false;

                _clienteVm.EnderecoEntrega = _clienteVm.Endereco;
                _clienteVm.BairroEntrega = _clienteVm.Bairro;
                _clienteVm.CidadeEntrega = _clienteVm.Cidade;
                _clienteVm.EstadoEntrega = _clienteVm.Estado;
                _clienteVm.CepEntrega = _clienteVm.Cep;
            }
            else
            {
                grpEnderecoEntrega.Enabled = true;

                _clienteVm.EnderecoEntrega = string.Empty;
                _clienteVm.BairroEntrega = string.Empty;
                _clienteVm.CidadeEntrega = string.Empty;
                _clienteVm.EstadoEntrega = string.Empty;
                _clienteVm.CepEntrega = string.Empty;
            }
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigo.DataBindings.Clear();
            txtCpfCnpj.DataBindings.Clear();
            txtRazaoSocial.DataBindings.Clear();
            txtNomeFantasia.DataBindings.Clear();
            txtEndereco.DataBindings.Clear();
            txtBairro.DataBindings.Clear();
            txtCidade.DataBindings.Clear();
            txtUF.DataBindings.Clear();
            txtCEP.DataBindings.Clear();
            chkUtilizarOMesmo.DataBindings.Clear();
            txtEnderecoEntrega.DataBindings.Clear();
            txtBairroEntrega.DataBindings.Clear();
            txtCidadeEntrega.DataBindings.Clear();
            txtUFEntrega.DataBindings.Clear();
            txtCEPEntrega.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _clienteVm, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCpfCnpj.DataBindings.Add("Text", _clienteVm, "CpfCnpj", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRazaoSocial.DataBindings.Add("Text", _clienteVm, "RazaoSocial", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomeFantasia.DataBindings.Add("Text", _clienteVm, "NomeFantasia", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEndereco.DataBindings.Add("Text", _clienteVm, "Endereco", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBairro.DataBindings.Add("Text", _clienteVm, "Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidade.DataBindings.Add("Text", _clienteVm, "Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUF.DataBindings.Add("Text", _clienteVm, "Estado", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCEP.DataBindings.Add("Text", _clienteVm, "Cep", false, DataSourceUpdateMode.OnPropertyChanged);
            chkUtilizarOMesmo.DataBindings.Add("Checked", _clienteVm, "UtilizarMesmoEnderecoParaEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEnderecoEntrega.DataBindings.Add("Text", _clienteVm, "EnderecoEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBairroEntrega.DataBindings.Add("Text", _clienteVm, "BairroEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidadeEntrega.DataBindings.Add("Text", _clienteVm, "CidadeEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUFEntrega.DataBindings.Add("Text", _clienteVm, "EstadoEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCEPEntrega.DataBindings.Add("Text", _clienteVm, "CepEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
        }        
    }
}
