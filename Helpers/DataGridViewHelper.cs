using System.Windows.Forms;

namespace ProjetoERP.Helpers
{
    public static class DataGridViewHelper
    {
        public static void ConfigurarColuna(
            DataGridView grid,
            string nomeColuna,
            string titulo,
            int largura,
            DataGridViewContentAlignment alinhamento = DataGridViewContentAlignment.MiddleLeft,
            string formato = null,
            bool visivel = true)
        {
            var coluna = grid.Columns[nomeColuna];

            if (coluna == null) return;

            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //visibilidade
            coluna.Visible = visivel;

            ////cores
            if (nomeColuna == "Situacao" || nomeColuna == "TipoMovimentacao")
            {
                grid.RowPrePaint += (sender, e) =>
                {
                    var dgv = (DataGridView)sender;
                    var row = dgv.Rows[e.RowIndex];

                    var valor = row.Cells[nomeColuna].Value?.ToString()?.ToLower();

                    switch (valor)
                    {
                        case "inativo":
                        case "saída":
                            row.DefaultCellStyle.ForeColor = Color.Red;
                            row.DefaultCellStyle.SelectionBackColor = Color.Red;
                            break;

                        case "ativo":
                        case "entrada":
                            row.DefaultCellStyle.ForeColor = Color.Blue;
                            break;
                    }
                };
            }            

            if (!visivel) return;

            //largura, cabeçalho e alinhamento
            coluna.Width = largura;
            coluna.HeaderText = titulo;
            coluna.DefaultCellStyle.Alignment = alinhamento;

            //formatação
            if (!string.IsNullOrWhiteSpace(formato))
            {
                switch (formato.ToLower())
                {
                    case "moeda":
                        coluna.DefaultCellStyle.Format = "C2";
                        break;

                    case "quantidade":
                        coluna.DefaultCellStyle.Format = "N3";
                        break;

                    case "data":
                        coluna.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;
                }
            }
        }
    }
}
