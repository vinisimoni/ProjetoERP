using ProjetoCadastro.Domain;
using ProjetoCadastro.Domain.Enums;
using ProjetoERP.Helpers;
using ProjetoERP.Services;

namespace ProjetoCadastro
{
    public partial class frmCadastroCliente : Form
    {
        private ClienteService _clienteService = new ClienteService();
        private Cliente _cliente = new Cliente();

        public frmCadastroCliente()
        {
            InitializeComponent();
            AtualizarBotaoExcluir();
            ConfigurarDataBindings();

            cboFiltroPessoa.Text = "Ambos";
            cboFiltroSituacao.Text = "Ambos";
            cboTipoFiltro.Text = "Razão Social";

            CarregarGridClientes();

            grdClientes.MouseWheel += grdClientes_MouseWheel;
        }

        private void HabilitarParaEdicao()
        {
            tabControl1.Enabled = true;
            btnIncluir.Text = "OK";
            btnExcluir.Text = "Cancelar";
            btnExcluir.Enabled = true;
            grdClientes.Enabled = false;
            txtCpfCnpj.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (btnIncluir.Text == "Incluir")
            {
                rbFisica.Checked = true;
                cboSitucao.Text = "Ativo";
                HabilitarParaEdicao();
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                txtCpfCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _cliente.CpfCnpj = txtCpfCnpj.Text;

                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _cliente.Endereco.Cep = txtCEP.Text;

                txtCEPEntrega.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _cliente.CepEntrega = txtCEPEntrega.Text;

                if (_cliente.Id == 0)
                {
                    _clienteService.Incluir(_cliente);
                }
                else
                {
                    _clienteService.Atualizar(_cliente);
                }

                LimparFormulario();
                CarregarGridClientes();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (btnExcluir.Text == "Excluir")
            {
                if (MessageBox.Show(
                        "Você realmente deseja excluir este registro?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _clienteService.Excluir(Convert.ToInt32(grdClientes.CurrentRow.Cells["Id"].Value));
                    CarregarGridClientes();
                }
            }
            else
            {
                LimparFormulario();
                CarregarGridClientes();
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
            cboSitucao.Text = "Ativo";
            LimparCampos();
            AtualizarBotaoExcluir();
        }

        private void LimparCampos()
        {
            if (_cliente.Id != 0)
                _clienteService.DetachedCliente(_cliente);

            txtCodigo.Text = "0";
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
                _cliente.TipoPessoa = ETipoPessoa.Física;
            }
            else if (rbJuridica.Checked)
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
                txtCpfCnpj.Clear();
                _cliente.TipoPessoa = ETipoPessoa.Jurídica;
            }
        }

        private void chkUtilizarOMesmo_CheckedChanged(object sender, EventArgs e)
        {
            this.Validate();

            if (chkUtilizarOMesmo.Checked)
            {
                grpEnderecoEntrega.Enabled = false;

                //_cliente.EnderecoEntrega = _cliente.Endereco;
                //_cliente.BairroEntrega = _cliente.Bairro;
                //_cliente.CidadeEntrega = _cliente.Cidade;
                //_cliente.EstadoEntrega = _cliente.Estado;
                //_cliente.CepEntrega = _cliente.Cep;

                _cliente.EnderecoEntrega = _cliente.Endereco.Rua;
                _cliente.BairroEntrega = _cliente.Endereco.Bairro;
                _cliente.CidadeEntrega = _cliente.Endereco.Cidade;
                _cliente.EstadoEntrega = _cliente.Endereco.Estado;
                _cliente.CepEntrega = _cliente.Endereco.Cep;
            }
            else
            {
                grpEnderecoEntrega.Enabled = true;

                _cliente.EnderecoEntrega = string.Empty;
                _cliente.BairroEntrega = string.Empty;
                _cliente.CidadeEntrega = string.Empty;
                _cliente.EstadoEntrega = string.Empty;
                _cliente.CepEntrega = string.Empty;
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
            cboSitucao.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _cliente, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCpfCnpj.DataBindings.Add("Text", _cliente, "CpfCnpj", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRazaoSocial.DataBindings.Add("Text", _cliente, "RazaoSocial", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomeFantasia.DataBindings.Add("Text", _cliente, "NomeFantasia", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtEndereco.DataBindings.Add("Text", _cliente.Endereco, "Endereco", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtBairro.DataBindings.Add("Text", _cliente.Endereco, "Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtCidade.DataBindings.Add("Text", _cliente.Endereco, "Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtUF.DataBindings.Add("Text", _cliente.Endereco, "Estado", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtCEP.DataBindings.Add("Text", _cliente.Endereco, "Cep", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEndereco.DataBindings.Add("Text", _cliente, "Endereco.Rua", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBairro.DataBindings.Add("Text", _cliente, "Endereco.Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidade.DataBindings.Add("Text", _cliente, "Endereco.Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUF.DataBindings.Add("Text", _cliente, "Endereco.Estado", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCEP.DataBindings.Add("Text", _cliente, "Endereco.Cep", false, DataSourceUpdateMode.OnPropertyChanged);
            chkUtilizarOMesmo.DataBindings.Add("Checked", _cliente, "UtilizarMesmoEnderecoParaEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEnderecoEntrega.DataBindings.Add("Text", _cliente, "EnderecoEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBairroEntrega.DataBindings.Add("Text", _cliente, "BairroEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidadeEntrega.DataBindings.Add("Text", _cliente, "CidadeEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUFEntrega.DataBindings.Add("Text", _cliente, "EstadoEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCEPEntrega.DataBindings.Add("Text", _cliente, "CepEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            cboSitucao.DataBindings.Add("Text", _cliente, "Situacao", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CarregarGridClientes()
        {
            int linhaSelecionada = -1;
            if (grdClientes.CurrentRow != null)
                linhaSelecionada = grdClientes.CurrentRow.Index;

            grdClientes.DataSource = _clienteService.CarregarClientesFiltro(cboFiltroSituacao.Text, cboFiltroPessoa.Text, cboTipoFiltro.Text, txtFiltro.Text);

            DataGridViewHelper.ConfigurarColuna(grdClientes, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdClientes, "CpfCnpj", "CPF/CNPJ", 150, DataGridViewContentAlignment.MiddleCenter, "CpfCnpj");
            DataGridViewHelper.ConfigurarColuna(grdClientes, "RazaoSocial", "Razão Social", 210);
            DataGridViewHelper.ConfigurarColuna(grdClientes, "Situacao", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdClientes, "TipoPessoa", "", 0, visivel: false);

            switch (cboTipoFiltro.Text)
            {
                case "Razão Social":
                case "Nome Fantasia":
                case "CPF/CNPJ":
                    DataGridViewHelper.ConfigurarColuna(grdClientes, "NomeFantasia", "Nome Fantasia", 210);
                    break;

                case "Endereço":
                    DataGridViewHelper.ConfigurarColuna(grdClientes, "Endereco", "Endereço", 210);
                    break;

                case "Cidade":
                    DataGridViewHelper.ConfigurarColuna(grdClientes, "Cidade", "Cidade", 210);
                    break;

                case "Endereço Entrega":
                    DataGridViewHelper.ConfigurarColuna(grdClientes, "EnderecoEntrega", "Endereço Entrega", 210);
                    break;

                case "Cidade Entrega":
                    DataGridViewHelper.ConfigurarColuna(grdClientes, "CidadeEntrega", "Cidade Entrega", 210);
                    break;

            }

            if (linhaSelecionada >= 0 && linhaSelecionada < grdClientes.Rows.Count)
                grdClientes.Rows[linhaSelecionada].Selected = true;
        }

        private void grdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grdClientes.Rows[e.RowIndex];
            var id = row.Cells["Id"].Value;
            if (id == null) return;

            _cliente = _clienteService.ObterPorId(Convert.ToInt32(id));

            rbFisica.CheckedChanged -= RadioButton_CheckedChanged;
            rbJuridica.CheckedChanged -= RadioButton_CheckedChanged;

            if (_cliente.TipoPessoa == ETipoPessoa.Física)
            {
                rbFisica.Checked = true;
                txtCpfCnpj.Mask = "000.000.000-00";
            }
            else
            {
                rbJuridica.Checked = true;
                txtCpfCnpj.Mask = "00.000.000/0000-00";
            }

            rbFisica.CheckedChanged += RadioButton_CheckedChanged;
            rbJuridica.CheckedChanged += RadioButton_CheckedChanged;

            ConfigurarDataBindings();
            HabilitarParaEdicao();
        }

        private void grdClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "CpfCnpj" && e.Value is string raw)
            {
                if (raw.Length == 11)
                {
                    e.Value = Convert.ToUInt64(raw).ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                }
                else if (raw.Length == 14)
                {
                    e.Value = Convert.ToUInt64(raw).ToString(@"00\.000\.000\/0000\-00");
                    e.FormattingApplied = true;
                }
            }
        }

        private void grdClientes_MouseWheel(object sender, MouseEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Rows.Count == 0)
                return;

            int linhaAtual = grid.CurrentRow?.Index ?? 0;

            // Se o delta for positivo, anda 1 linha para cima; se negativo, 1 linha para baixo
            int linhasASomar = (e.Delta > 0) ? -1 : 1;

            int novaLinha = linhaAtual + linhasASomar;

            // Limitar o índice para não sair do intervalo válido
            if (novaLinha < 0) novaLinha = 0;
            if (novaLinha >= grid.Rows.Count) novaLinha = grid.Rows.Count - 1;

            grid.ClearSelection();
            grid.Rows[novaLinha].Selected = true;
            grid.CurrentCell = grid.Rows[novaLinha].Cells[0];
            grid.FirstDisplayedScrollingRowIndex = novaLinha;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarGridClientes();
        }
    }
}
