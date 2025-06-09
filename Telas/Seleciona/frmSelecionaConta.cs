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
    public partial class frmSelecionaConta : Form
    {
        public int ContaSelecionada { get; private set; }
        private ContaService _contaService = new ContaService();

        public frmSelecionaConta()
        {
            InitializeComponent();
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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarConta();
        }

        private void SelecionarConta()
        {
            if (grdContas.CurrentRow?.DataBoundItem != null)
            {
                dynamic item = grdContas.CurrentRow.DataBoundItem;
                ContaSelecionada = item.Id;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void grdContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                SelecionarConta();
        }

        private void frmSelecionaConta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
