using ProjetoCadastro.Domain;
using ProjetoERP.Domain;
using ProjetoERP.Helpers;
using ProjetoERP.Repositories;

namespace ProjetoERP.Telas
{
    public partial class frmCadastroMaterial : Form
    {
        private MaterialRepositorio _materialRepo = new MaterialRepositorio();
        private Material _material = new Material();
        public frmCadastroMaterial()
        {
            InitializeComponent();
            AtualizarBotaoExcluir();
            ConfigurarDataBindings();

            //cboFiltroPessoa.Text = "Ambos";
            //cboFiltroSituacao.Text = "Ambos";
            //cboTipoFiltro.Text = "Razão Social";

            CarregarGridMateriais();

            grdMateriais.MouseWheel += grdMateriais_MouseWheel;
        }

        private void grdMateriais_MouseWheel(object sender, MouseEventArgs e)
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

        private void CarregarGridMateriais()
        {
            int linhaSelecionada = -1;
            if (grdMateriais.CurrentRow != null)
                linhaSelecionada = grdMateriais.CurrentRow.Index;

            //grdMateriais.DataSource = _clienteRepo.CarregarClientesFiltro(cboFiltroSituacao.Text, cboFiltroPessoa.Text, cboTipoFiltro.Text, txtFiltro.Text);

            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Descricao", "Descrição", 210, DataGridViewContentAlignment.MiddleCenter, "CpfCnpj");
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Referencia", "Referência", 150);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Unidade", "UN", 50);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Situacao", "", 0, visivel: false);           

            if (linhaSelecionada >= 0 && linhaSelecionada < grdMateriais.Rows.Count)
                grdMateriais.Rows[linhaSelecionada].Selected = true;
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigo.DataBindings.Clear();
            txtDescricao.DataBindings.Clear();
            txtReferencia.DataBindings.Clear();
            txtUN.DataBindings.Clear();
            chkControlaEstoque.DataBindings.Clear();
            txtEstoqueAtual.DataBindings.Clear();
            txtValorVenda.DataBindings.Clear();
            cboSitucao.DataBindings.Clear();

            // Cria novos bindings
            txtCodigo.DataBindings.Add("Text", _material, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _material, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtReferencia.DataBindings.Add("Text", _material, "Referencia", false, DataSourceUpdateMode.OnPropertyChanged);
            chkControlaEstoque.DataBindings.Add("Checked", _material, "ControlaEstoque", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUN.DataBindings.Add("Text", _material, "Unidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValorVenda.DataBindings.Add("Text", _material, "ValorVenda", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEstoqueAtual.DataBindings.Add("Text", _material, "EstoqueAtual", false, DataSourceUpdateMode.OnPropertyChanged);            
            cboSitucao.DataBindings.Add("Text", _material, "Situacao", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AtualizarBotaoExcluir()
        {
            bool temLinha = grdMateriais.Rows.Count > 0;
            bool linhaSelecionada = grdMateriais.CurrentRow != null && grdMateriais.CurrentRow.Index >= 0;

            btnExcluir.Enabled = temLinha && linhaSelecionada;
        }

        private void HabilitarParaEdicao()
        {
            tabControl1.Enabled = true;
            btnIncluir.Text = "OK";
            btnExcluir.Text = "Cancelar";
            btnExcluir.Enabled = true;
            grdMateriais.Enabled = false;
            txtDescricao.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (btnIncluir.Text == "Incluir")
            {
                cboSitucao.Text = "Ativo";
                txtEstoqueAtual.Text = "0,000";
                txtValorVenda.Text = "0,00";
                HabilitarParaEdicao();
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                if (_material.Id == 0)
                {
                    _materialRepo.Incluir(_material);
                }
                else
                {
                    _materialRepo.Atualizar(_material);
                }

                LimparFormulario();
                CarregarGridMateriais();
            }
        }

        private void LimparCampos()
        {
            if (_material.Id != 0)
                _materialRepo.DetachedMaterial(_material);

            txtCodigo.Text = "0";
            txtDescricao.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtUN.Text = string.Empty;
            txtEstoqueAtual.Text = string.Empty;
            txtValorVenda.Text = string.Empty;
        }

        private void LimparFormulario()
        {
            grdMateriais.Enabled = true;
            tabControl1.Enabled = false;
            chkControlaEstoque.Checked = false;
            btnIncluir.Text = "Incluir";
            btnExcluir.Text = "Excluir";
            cboSitucao.Text = "Ativo";
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

            if (string.IsNullOrWhiteSpace(txtUN.Text))
            {
                MessageBox.Show("O campo UN é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUN.Focus();
                return false;
            }

            return true;
        }
    }
}
