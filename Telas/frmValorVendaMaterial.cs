using ProjetoERP.Domain;
using ProjetoERP.Helpers;
using ProjetoERP.Services;
using ProjetoERP.Telas.Seleciona;

namespace ProjetoERP.Telas
{
    public partial class frmValorVendaMaterial : Form
    {
        private MaterialService _materialService = new MaterialService();
        private HistoricoValorVenda _histVal = new HistoricoValorVenda();
        private long _valorInterno = 0;
        private bool _negativo = false;

        public frmValorVendaMaterial()
        {
            InitializeComponent();
            ConfigurarDataBindings();
        }

        private void ConfigurarDataBindings()
        {
            // Limpa os bindings anteriores
            txtCodigoMaterial.DataBindings.Clear();
            txtValorAnterior.DataBindings.Clear();
            txtValorNovo.DataBindings.Clear();

            // Cria novos bindings
            txtCodigoMaterial.DataBindings.Add("Text", _histVal, "IdMaterial", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValorAnterior.DataBindings.Add("Text", _histVal, "ValorAnterior", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValorNovo.DataBindings.Add("Text", _histVal, "ValorNovo", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSelecionaMaterial_Click(object sender, EventArgs e)
        {
            frmSelecionaMaterial selecionaMat = new frmSelecionaMaterial(somenteAtivos: true);

            if (selecionaMat.ShowDialog() == DialogResult.OK && selecionaMat.MaterialSelecionado != 0)
            {
                txtCodigoMaterial.Text = selecionaMat.MaterialSelecionado.ToString();
                txtDescricaoMaterial.Text = _materialService.ObterDescricaoPorId(selecionaMat.MaterialSelecionado);
                CarregarGrid(selecionaMat.MaterialSelecionado);
            }
        }

        private void CarregarGrid(int id)
        {
            int linhaSelecionada = -1;
            if (grdValoresMaterial.CurrentRow != null)
                linhaSelecionada = grdValoresMaterial.CurrentRow.Index;

            grdValoresMaterial.DataSource = _materialService.CarregarValoresVendaMaterial(id);

            DataGridViewHelper.ConfigurarColuna(grdValoresMaterial, "IdMaterial", "", 0, visivel: false);
            DataGridViewHelper.ConfigurarColuna(grdValoresMaterial, "DataLancamento", "Data Lançamento", 150, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewHelper.ConfigurarColuna(grdValoresMaterial, "ValorAnterior", "Valor Anterior", 150, DataGridViewContentAlignment.MiddleRight, "moeda");
            DataGridViewHelper.ConfigurarColuna(grdValoresMaterial, "ValorNovo", "Valor Novo", 150, DataGridViewContentAlignment.MiddleRight, "moeda");

            if (linhaSelecionada >= 0 && linhaSelecionada < grdValoresMaterial.Rows.Count)
                grdValoresMaterial.Rows[linhaSelecionada].Selected = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoMaterial.Text = string.Empty;
            txtDescricaoMaterial.Text = string.Empty;
            grdValoresMaterial.DataSource = null;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoMaterial.Text))
            {
                MessageBox.Show("Informe o material.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnIncluir.Text == "Incluir")
            {
                _histVal.Id = 0;
                _histVal.ValorAnterior = _materialService.ObterValorVendaPorId(Convert.ToInt32(txtCodigoMaterial.Text));
                txtValorNovo.Text = "0,00";
                HabilitarParaEdicao();
            }
            else
            {
                this.Validate();

                if (!ValidarCampos())
                    return;

                _materialService.Incluir(_histVal);

                LimparFormulario();
                CarregarGrid(Convert.ToInt32(txtCodigoMaterial.Text));
            }
        }

        public void HabilitarParaEdicao()
        {
            btnCancelar.Enabled = true;
            tabControl1.Enabled = true;
            btnSelecionaMaterial.Enabled = false;
            btnLimpar.Enabled = false;
            btnIncluir.Text = "OK";
            txtValorNovo.Focus();
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
            txtValorAnterior.Text = string.Empty;
            txtValorNovo.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtValorNovo.Text) || decimal.Parse(txtValorNovo.Text) == 0)
            {
                MessageBox.Show("O campo Valor Novo é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorNovo.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            CarregarGrid(Convert.ToInt32(txtCodigoMaterial.Text));
        }

        private void txtValorNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var resultado = TextBoxHelper.ProcessarTecla(
                _valorInterno, e.KeyChar, ref _negativo, out bool handled, 2);

            _valorInterno = resultado.NovoValorInterno;
            txtValorNovo.Text = resultado.TextoFormatado;
            txtValorNovo.SelectionStart = txtValorNovo.Text.Length;
            e.Handled = handled;
        }
    }
}
