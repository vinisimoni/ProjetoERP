using ProjetoCadastro.Domain.Enums;
using ProjetoERP.Domain;
using ProjetoERP.Helpers;
using ProjetoERP.Services;

namespace ProjetoERP.Telas
{
    public partial class frmCadastroFornecedor : Form
    {
        private FornecedorService _fornecedorService = new FornecedorService();
        private Fornecedor _fornecedor = new Fornecedor();

        public frmCadastroFornecedor()
        {
            InitializeComponent();
            ConfigurarDataBindings();

            grdFornecedores.MouseWheel += grdFornecedores_MouseWheel;
        }

        private void grdFornecedores_MouseWheel(object sender, MouseEventArgs e)
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

        private void AtualizarBotaoExcluir()
        {
            bool temLinha = grdFornecedores.Rows.Count > 0;
            bool linhaSelecionada = grdFornecedores.CurrentRow != null && grdFornecedores.CurrentRow.Index >= 0;

            btnExcluir.Enabled = temLinha && linhaSelecionada;
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
            cboSitucao.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _fornecedor, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCpfCnpj.DataBindings.Add("Text", _fornecedor, "Dados.CpfCnpj", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRazaoSocial.DataBindings.Add("Text", _fornecedor, "Dados.RazaoSocial", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomeFantasia.DataBindings.Add("Text", _fornecedor, "Dados.NomeFantasia", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEndereco.DataBindings.Add("Text", _fornecedor, "Endereco.Rua", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBairro.DataBindings.Add("Text", _fornecedor, "Endereco.Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidade.DataBindings.Add("Text", _fornecedor, "Endereco.Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUF.DataBindings.Add("Text", _fornecedor, "Endereco.Estado", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCEP.DataBindings.Add("Text", _fornecedor, "Endereco.Cep", false, DataSourceUpdateMode.OnPropertyChanged);
            cboSitucao.DataBindings.Add("Text", _fornecedor, "Situacao", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void HabilitarParaEdicao()
        {
            tabControl1.Enabled = true;
            btnIncluir.Text = "OK";
            btnExcluir.Text = "Cancelar";
            btnExcluir.Enabled = true;
            grdFornecedores.Enabled = false;
            txtRazaoSocial.Focus();
        }

        private void LimparCampos()
        {
            if (_fornecedor.Id != 0)
                _fornecedorService.DetachedFornecedor(_fornecedor);

            txtCodigo.Text = "0";
            txtCpfCnpj.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCEP.Text = string.Empty;
        }

        private void LimparFormulario()
        {
            grdFornecedores.Enabled = true;
            tabControl1.Enabled = false;
            rbFisica.Checked = true;
            btnIncluir.Text = "Incluir";
            btnExcluir.Text = "Excluir";
            cboSitucao.Text = "Ativo";
            LimparCampos();
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

            return true;
        }

        private void CarregarGrid()
        {
            int linhaSelecionada = -1;
            if (grdFornecedores.CurrentRow != null)
                linhaSelecionada = grdFornecedores.CurrentRow.Index;

            grdFornecedores.DataSource = _fornecedorService.CarregarFornecedores();

            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "CpfCnpj", "CPF/CNPJ", 150, DataGridViewContentAlignment.MiddleCenter, "CpfCnpj");
            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "RazaoSocial", "Razão Social", 210);
            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "NomeFantasia", "Nome Fantasia", 210);
            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "Situacao", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdFornecedores, "TipoPessoa", "", 0, visivel: false);

            if (linhaSelecionada >= 0 && linhaSelecionada < grdFornecedores.Rows.Count)
                grdFornecedores.Rows[linhaSelecionada].Selected = true;
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
            CarregarGrid();
        }

        private void grdFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
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
                _fornecedor.Dados.CpfCnpj = txtCpfCnpj.Text;

                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                _fornecedor.Endereco.Cep = txtCEP.Text;

                if (_fornecedor.Id == 0)
                {
                    _fornecedorService.Incluir(_fornecedor);
                }
                else
                {
                    _fornecedorService.Atualizar(_fornecedor);
                }

                LimparFormulario();
                CarregarGrid();
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
                    _fornecedorService.Excluir(Convert.ToInt32(grdFornecedores.CurrentRow.Cells["Id"].Value));
                    CarregarGrid();
                }
            }
            else
            {
                LimparFormulario();
                CarregarGrid();
            }
        }

        private void grdFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grdFornecedores.Rows[e.RowIndex];
            var id = row.Cells["Id"].Value;
            if (id == null) return;

            _fornecedor = _fornecedorService.ObterPorId(Convert.ToInt32(id));

            rbFisica.CheckedChanged -= RadioButton_CheckedChanged;
            rbJuridica.CheckedChanged -= RadioButton_CheckedChanged;

            if (_fornecedor.Dados.TipoPessoa == ETipoPessoa.Física)
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

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                txtCpfCnpj.Mask = "000.000.000-00";
                txtCpfCnpj.Clear();
                _fornecedor.Dados.TipoPessoa = ETipoPessoa.Física;
            }
            else if (rbJuridica.Checked)
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
                txtCpfCnpj.Clear();
                _fornecedor.Dados.TipoPessoa = ETipoPessoa.Jurídica;
            }
        }

        private void grdFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
