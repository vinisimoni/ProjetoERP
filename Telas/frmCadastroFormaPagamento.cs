using ProjetoCadastro.Domain;
using ProjetoERP.Domain;
using ProjetoERP.Helpers;
using ProjetoERP.Services;
using ProjetoERP.Telas.Seleciona;
using System.Windows.Forms;

namespace ProjetoERP.Telas
{
    public partial class frmCadastroFormaPagamento : Form
    {
        private FormaPagamentoService _formaService = new FormaPagamentoService();
        private FormaPagamento _forma = new FormaPagamento();
        private long _valorInterno = 0;
        private bool _negativo = false;

        public frmCadastroFormaPagamento()
        {
            InitializeComponent();
            ConfigurarDataBindings();

            grdFormasPgto.MouseWheel += grdFormasPgto_MouseWheel;
        }

        private void grdFormasPgto_MouseWheel(object sender, MouseEventArgs e)
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

        private void frmCadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
            CarregarGrid();
        }

        private void AtualizarBotaoExcluir()
        {
            bool temLinha = grdFormasPgto.Rows.Count > 0;
            bool linhaSelecionada = grdFormasPgto.CurrentRow != null && grdFormasPgto.CurrentRow.Index >= 0;

            grdFormasPgto.Enabled = temLinha && linhaSelecionada;
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigo.DataBindings.Clear();
            txtDescricao.DataBindings.Clear();
            cboSitucao.DataBindings.Clear();
            txtMaxParcelas.DataBindings.Clear();
            txtTaxaAdm.DataBindings.Clear();
            txtDiasRecebimento.DataBindings.Clear();
            chkAVista.DataBindings.Clear();
            chkAtualizarVencimentos.DataBindings.Clear();
            chkPermiteVenda.DataBindings.Clear();
            chkPermiteRecebimento.DataBindings.Clear();
            chkPermiteCompra.DataBindings.Clear();
            chkPermitePagamento.DataBindings.Clear();
            txtCodigoConta.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _forma, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _forma, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            cboSitucao.DataBindings.Add("Text", _forma, "Situacao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMaxParcelas.DataBindings.Add("Text", _forma, "MaxParcelas", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTaxaAdm.DataBindings.Add("Text", _forma, "TaxaAdministradora", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDiasRecebimento.DataBindings.Add("Text", _forma, "DiasRecebimento", false, DataSourceUpdateMode.OnPropertyChanged);
            chkAVista.DataBindings.Add("Checked", _forma, "AVista", false, DataSourceUpdateMode.OnPropertyChanged);
            chkAtualizarVencimentos.DataBindings.Add("Checked", _forma, "AtualizarVencimentos", false, DataSourceUpdateMode.OnPropertyChanged);
            chkPermiteVenda.DataBindings.Add("Checked", _forma, "PermiteVenda", false, DataSourceUpdateMode.OnPropertyChanged);
            chkPermiteRecebimento.DataBindings.Add("Checked", _forma, "PermiteRecebimento", false, DataSourceUpdateMode.OnPropertyChanged);
            chkPermiteCompra.DataBindings.Add("Checked", _forma, "PermiteCompra", false, DataSourceUpdateMode.OnPropertyChanged);
            chkPermitePagamento.DataBindings.Add("Checked", _forma, "PermitePagamento", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigoConta.DataBindings.Add("Text", _forma, "IdConta", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void HabilitarParaEdicao()
        {
            tabControl1.Enabled = true;
            btnIncluir.Text = "OK";
            btnExcluir.Text = "Cancelar";
            btnExcluir.Enabled = true;
            grdFormasPgto.Enabled = false;
            txtDescricao.Focus();
        }

        private void LimparCampos()
        {
            if (_forma.Id != 0)
                _formaService.Detached(_forma);

            txtCodigo.Text = "0";
            txtDescricao.Text = string.Empty;
            txtMaxParcelas.Text = string.Empty;
            txtTaxaAdm.Text = string.Empty;
            txtDiasRecebimento.Text = string.Empty;
            txtCodigoConta.Text = string.Empty;
            txtDescricaoConta.Text = string.Empty;
        }

        private void LimparFormulario()
        {
            grdFormasPgto.Enabled = true;
            tabControl1.Enabled = false;
            chkAVista.Checked = false;
            chkAtualizarVencimentos.Checked = false;
            chkPermiteVenda.Checked = false;
            chkPermiteRecebimento.Checked = false;
            chkPermiteCompra.Checked = false;
            chkPermitePagamento.Checked = false;
            btnIncluir.Text = "Incluir";
            btnExcluir.Text = "Excluir";
            _negativo = false;
            _valorInterno = 0;
            LimparCampos();
            AtualizarBotaoExcluir();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("O campo Descrição é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoConta.Text))
            {
                MessageBox.Show("O campo Conta é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CarregarGrid()
        {
            int linhaSelecionada = -1;
            if (grdFormasPgto.CurrentRow != null)
                linhaSelecionada = grdFormasPgto.CurrentRow.Index;

            grdFormasPgto.DataSource = _formaService.CarregarFormasPagamento();

            DataGridViewHelper.ConfigurarColuna(grdFormasPgto, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdFormasPgto, "Descricao", "Descrição", 270);

            if (linhaSelecionada >= 0 && linhaSelecionada < grdFormasPgto.Rows.Count)
                grdFormasPgto.Rows[linhaSelecionada].Selected = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (btnIncluir.Text == "Incluir")
            {
                _forma.Id = 0;
                cboSitucao.Text = "Ativo";
                HabilitarParaEdicao();
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                if (_forma.Id == 0)
                {
                    _formaService.Incluir(_forma);
                }
                else
                {
                    _formaService.Atualizar(_forma);
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
                    _formaService.Excluir(Convert.ToInt32(grdFormasPgto.CurrentRow.Cells["Id"].Value));
                    CarregarGrid();
                }
            }
            else
            {
                LimparFormulario();
                CarregarGrid();
            }
        }

        private void grdFormasPgto_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
        }

        private void grdFormasPgto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grdFormasPgto.Rows[e.RowIndex];
            var id = row.Cells["Id"].Value;
            if (id == null) return;

            _forma = _formaService.ObterPorId(Convert.ToInt32(id));

            ContaService contaService = new ContaService();

            txtDescricaoConta.Text = contaService.ObterDescricaoPorId(_forma.IdConta);

            ConfigurarDataBindings();
            HabilitarParaEdicao();
        }

        private void txtMaxParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido
            }
        }

        private void txtDiasRecebimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido
            }
        }

        private void txtTaxaAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            var resultado = TextBoxHelper.ProcessarTecla(
                _valorInterno, e.KeyChar, ref _negativo, out bool handled, 2);

            _valorInterno = resultado.NovoValorInterno;
            txtTaxaAdm.Text = resultado.TextoFormatado;
            txtTaxaAdm.SelectionStart = txtTaxaAdm.Text.Length;
            e.Handled = handled;
        }

        private void btnSelecionaMaterial_Click(object sender, EventArgs e)
        {
            frmSelecionaConta selecionaConta = new frmSelecionaConta();

            if (selecionaConta.ShowDialog() == DialogResult.OK && selecionaConta.ContaSelecionada != 0)
            {
                ContaService contaService = new ContaService();

                txtCodigoConta.Text = selecionaConta.ContaSelecionada.ToString();
                txtDescricaoConta.Text = contaService.ObterDescricaoPorId(selecionaConta.ContaSelecionada);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoConta.Text = string.Empty;
            txtDescricaoConta.Text = string.Empty;
        }
    }
}
