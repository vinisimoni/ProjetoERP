using ProjetoERP.Domain;
using ProjetoERP.Domain.Enums;
using ProjetoERP.Helpers;
using ProjetoERP.Services;
using ProjetoERP.Telas.Seleciona;

namespace ProjetoERP.Telas
{
    public partial class frmEntradaSaidaEstoque : Form
    {
        private MaterialService _materialService = new MaterialService();
        private MovimentacaoEstoque _movEst = new MovimentacaoEstoque();
        private long _valorInterno = 0;
        private bool _negativo = false;

        public frmEntradaSaidaEstoque()
        {
            InitializeComponent();
            ConfigurarDataBindings();
        }

        private void CarregarGridMovimentacao(int id)
        {
            int linhaSelecionada = -1;
            if (grdMovMateriais.CurrentRow != null)
                linhaSelecionada = grdMovMateriais.CurrentRow.Index;

            grdMovMateriais.DataSource = _materialService.CarregarMovMateriaisManual(id);

            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "Id", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "IdMaterial", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "OrigemMovimentacao", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "DataMovimentacao", "Data Movimentação", 150, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "TipoMovimentacao", "Tipo", 100);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "Descricao", "Descrição", 315);
            DataGridViewHelper.ConfigurarColuna(grdMovMateriais, "Quantidade", "Quantidade", 100, DataGridViewContentAlignment.MiddleRight, "quantidade");

            if (linhaSelecionada >= 0 && linhaSelecionada < grdMovMateriais.Rows.Count)
                grdMovMateriais.Rows[linhaSelecionada].Selected = true;
        }

        private void btnSelecionaMaterial_Click(object sender, EventArgs e)
        {
            frmSelecionaMaterial selecionaMat = new frmSelecionaMaterial(somenteAtivos: true, somenteControlaEstoque: true);

            if (selecionaMat.ShowDialog() == DialogResult.OK && selecionaMat.MaterialSelecionado != 0)
            {
                txtCodigoMaterial.Text = selecionaMat.MaterialSelecionado.ToString();
                txtDescricaoMaterial.Text = _materialService.ObterDescricaoPorId(selecionaMat.MaterialSelecionado);
                CarregarGridMovimentacao(selecionaMat.MaterialSelecionado);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoMaterial.Text = string.Empty;
            txtDescricaoMaterial.Text = string.Empty;
            grdMovMateriais.DataSource = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            CarregarGridMovimentacao(Convert.ToInt32(txtCodigoMaterial.Text));
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoMaterial.Text) || txtCodigoMaterial.Text == "0")
            {
                MessageBox.Show("Informe o material.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnIncluir.Text == "Incluir")
            {
                _movEst.Id = 0;
                _movEst.OrigemMovimentacao = EOrigemMovMaterial.Manual;
                cboTipo.Text = "Entrada";
                txtQuantidade.Text = "0,000";
                HabilitarParaEdicao();                
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                _materialService.Incluir(_movEst);

                LimparFormulario();
                CarregarGridMovimentacao(Convert.ToInt32(txtCodigoMaterial.Text));
            }
        }

        private void LimparFormulario()
        {
            btnSelecionaMaterial.Enabled = true;
            btnLimpar.Enabled = true;
            tabControl1.Enabled = false;
            btnIncluir.Text = "Incluir";
            btnCancelar.Enabled = false;
            _negativo = false;
            _valorInterno = 0;
            LimparCampos();
        }

        private void LimparCampos()
        {           
            txtDescricao.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("O campo Descrição é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || decimal.Parse(txtQuantidade.Text) == 0)
            {
                MessageBox.Show("O campo Quantidade é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return false;
            }

            return true;
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigoMaterial.DataBindings.Clear();
            txtDescricao.DataBindings.Clear();
            txtQuantidade.DataBindings.Clear();
            cboTipo.DataBindings.Clear();

            // Cria novos bindings
            txtCodigoMaterial.DataBindings.Add("Text", _movEst, "IdMaterial", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _movEst, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtQuantidade.DataBindings.Add("Text", _movEst, "Quantidade", false, DataSourceUpdateMode.OnPropertyChanged);
            cboTipo.DataBindings.Add("Text", _movEst, "TipoMovimentacao", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void HabilitarParaEdicao()
        {
            btnCancelar.Enabled = true;
            tabControl1.Enabled = true;
            btnSelecionaMaterial.Enabled = false;
            btnLimpar.Enabled = false;
            btnIncluir.Text = "OK";
            txtQuantidade.Focus();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            var resultado = TextBoxHelper.ProcessarTecla(
                _valorInterno, e.KeyChar, ref _negativo, out bool handled, 3);

            _valorInterno = resultado.NovoValorInterno;
            txtQuantidade.Text = resultado.TextoFormatado;
            txtQuantidade.SelectionStart = txtQuantidade.Text.Length;
            e.Handled = handled;
        }
    }
}
