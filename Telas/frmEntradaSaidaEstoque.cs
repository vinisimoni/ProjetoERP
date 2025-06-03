using ProjetoERP.Domain;
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

namespace ProjetoERP.Telas
{
    public partial class frmEntradaSaidaEstoque : Form
    {
        private MaterialService _materialService = new MaterialService();

        public frmEntradaSaidaEstoque()
        {
            InitializeComponent();
            CarregarGridMateriais();
        }

        private void CarregarGridMateriais()
        {
            int linhaSelecionada = -1;
            if (grdMateriais.CurrentRow != null)
                linhaSelecionada = grdMateriais.CurrentRow.Index;

            //grdMateriais.DataSource = _clienteRepo.CarregarClientesFiltro(cboFiltroSituacao.Text, cboFiltroPessoa.Text, cboTipoFiltro.Text, txtFiltro.Text);
            grdMateriais.DataSource = _materialService.CarregarMateriaisControlaEstoque();

            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Id", "Código", 100, DataGridViewContentAlignment.MiddleRight);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Descricao", "Descrição", 230);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Referencia", "Referência", 230);
            DataGridViewHelper.ConfigurarColuna(grdMateriais, "Unidade", "UN", 105);

            if (linhaSelecionada >= 0 && linhaSelecionada < grdMateriais.Rows.Count)
                grdMateriais.Rows[linhaSelecionada].Selected = true;
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

        private void grdMateriais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grdMateriais.Rows[e.RowIndex];
            var id = row.Cells["Id"].Value;
            if (id == null) return;

            CarregarGridMovimentacao(Convert.ToInt32(id));
        }
    }
}
