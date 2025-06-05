using ProjetoERP.Helpers;
using ProjetoERP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP.Telas.Seleciona
{
    public partial class frmSelecionaMaterial : Form
    {
        public int MaterialSelecionado { get; private set; }

        private bool _somenteComEstoque;
        private bool _somenteAtivos;
        private bool _somenteControlaEstoque;
        private MaterialService _materialService = new MaterialService();

        public frmSelecionaMaterial(bool somenteComEstoque = false, bool somenteAtivos = false, bool somenteControlaEstoque = false)
        {
            InitializeComponent();
            _somenteComEstoque = somenteComEstoque;
            _somenteAtivos = somenteAtivos;
            _somenteControlaEstoque = somenteControlaEstoque;
        }

        private void frmSelecionaMaterial_Load(object sender, EventArgs e)
        {
            cboFiltroSituacao.Text = "Ambos";
            cboFiltroEstoque.Text = "Ambos";
            cboFiltroTipo.Text = "Descrição";

            if (_somenteAtivos)
            {
                cboFiltroSituacao.Text = "Ativo";
                cboFiltroSituacao.Enabled = false;
            }

            if (_somenteComEstoque)
            {
                cboFiltroEstoque.Text = "Com Estoque";
                cboFiltroEstoque.Enabled = false;
            }

            CarregarGridMateriais();
        }

        private void SelecionarMaterial()
        {
            if (grdMateriais.CurrentRow?.DataBoundItem != null)
            {
                dynamic item = grdMateriais.CurrentRow.DataBoundItem;
                MaterialSelecionado = item.Id;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CarregarGridMateriais()
        {
            int linhaSelecionada = -1;
            if (grdMateriais.CurrentRow != null)
                linhaSelecionada = grdMateriais.CurrentRow.Index;

            grdMateriais.DataSource = _materialService.CarregarMateriaisFiltro(cboFiltroSituacao.Text, cboFiltroEstoque.Text, cboFiltroTipo.Text, txtFiltro.Text, _somenteControlaEstoque);

            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Descricao", "Descrição", 230);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Referencia", "Referência", 230);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Unidade", "UN", 105);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Situacao", "", 0, visivel: false);

            if (linhaSelecionada >= 0 && linhaSelecionada < grdMateriais.Rows.Count)
                grdMateriais.Rows[linhaSelecionada].Selected = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarGridMateriais();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarMaterial();
        }

        private void grdMateriais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                SelecionarMaterial();
        }
    }
}
