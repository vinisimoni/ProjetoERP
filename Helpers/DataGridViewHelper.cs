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

            //cores
            grid.RowPrePaint += (sender, e) =>
            {
                var dgv = (DataGridView)sender;
                var row = dgv.Rows[e.RowIndex];

                var valor = row.Cells[nomeColuna].Value?.ToString()?.ToLower();

                switch (valor)
                {
                    case "inativo":
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.SelectionBackColor = Color.Red;
                        break;
                }
            };

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

                    case "data":
                        coluna.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;

                    case "cpfcnpj":

                        grid.CellFormatting += (sender, e) =>
                        {
                            if (grid.Columns[e.ColumnIndex].Name == nomeColuna &&
                                e.Value is string raw && (raw.Length == 11 || raw.Length == 14))
                            {
                                if (raw.Length == 11)
                                    e.Value = Convert.ToUInt64(raw).ToString(@"000\.000\.000\-00");
                                else
                                    e.Value = Convert.ToUInt64(raw).ToString(@"00\.000\.000\/0000\-00");

                                e.FormattingApplied = true;
                            }
                        };
                        break;
                }
            }            
        }
    }
}
