using ProjetoERP.Domain;
using ProjetoERP.Helpers;
using ProjetoERP.Services;

namespace ProjetoERP.Telas
{
    public partial class frmCadastroConta : Form
    {
        private ContaService _contaService = new ContaService();
        private Conta _conta = new Conta();

        public frmCadastroConta()
        {
            InitializeComponent();
            ConfigurarDataBindings();

            grdContas.MouseWheel += grdContas_MouseWheel;
        }

        private void grdContas_MouseWheel(object sender, MouseEventArgs e)
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

        private void frmCadastroConta_Load(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
            CarregarGrid();
        }

        private void AtualizarBotaoExcluir()
        {
            bool temLinha = grdContas.Rows.Count > 0;
            bool linhaSelecionada = grdContas.CurrentRow != null && grdContas.CurrentRow.Index >= 0;

            btnExcluir.Enabled = temLinha && linhaSelecionada;
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigo.DataBindings.Clear();
            txtDescricao.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _conta, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _conta, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void HabilitarParaEdicao()
        {
            tabControl1.Enabled = true;
            btnIncluir.Text = "OK";
            btnExcluir.Text = "Cancelar";
            btnExcluir.Enabled = true;
            grdContas.Enabled = false;
            txtDescricao.Focus();
        }

        private void LimparCampos()
        {
            if (_conta.Id != 0)
                _contaService.Detached(_conta);

            txtCodigo.Text = "0";
            txtDescricao.Text = string.Empty;
        }

        private void LimparFormulario()
        {
            grdContas.Enabled = true;
            tabControl1.Enabled = false;
            btnIncluir.Text = "Incluir";
            btnExcluir.Text = "Excluir";
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

            return true;
        }

        private void CarregarGrid()
        {
            int linhaSelecionada = -1;
            if (grdContas.CurrentRow != null)
                linhaSelecionada = grdContas.CurrentRow.Index;

            grdContas.DataSource = _contaService.CarregarContas();

            DataGridViewHelper.ConfigurarColuna(grdContas, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdContas, "Descricao", "Descrição", 270);

            if (linhaSelecionada >= 0 && linhaSelecionada < grdContas.Rows.Count)
                grdContas.Rows[linhaSelecionada].Selected = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (btnIncluir.Text == "Incluir")
            {
                _conta.Id = 0;
                HabilitarParaEdicao();
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                if (_conta.Id == 0)
                {
                    _contaService.Incluir(_conta);
                }
                else
                {
                    _contaService.Atualizar(_conta);
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
                    _contaService.Excluir(Convert.ToInt32(grdContas.CurrentRow.Cells["Id"].Value));
                    CarregarGrid();
                }
            }
            else
            {
                LimparFormulario();
                CarregarGrid();
            }
        }

        private void grdContas_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotaoExcluir();
        }

        private void grdContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grdContas.Rows[e.RowIndex];
            var id = row.Cells["Id"].Value;
            if (id == null) return;

            _conta = _contaService.ObterPorId(Convert.ToInt32(id));

            ConfigurarDataBindings();
            HabilitarParaEdicao();
        }
    }
}
