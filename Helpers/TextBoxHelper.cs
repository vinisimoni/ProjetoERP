namespace ProjetoERP.Helpers
{
    public static class TextBoxHelper
    {
        public static (long NovoValorInterno, string TextoFormatado) ProcessarTecla(
            long valorAtual,
            char tecla,
            ref bool negativo,
            out bool handled,
            int casasDecimais = 2,
            bool permitirNegativo = true)
        {
            handled = true;

            if (char.IsDigit(tecla))
            {
                valorAtual = valorAtual * 10 + (tecla - '0');
            }
            else if (tecla == (char)Keys.Back)
            {
                valorAtual = valorAtual / 10;
            }
            else if (tecla == '-' && valorAtual == 0 && permitirNegativo)
            {
                negativo = !negativo;
            }
            else
            {
                // tecla inválida
                return (valorAtual, FormatValor(valorAtual, negativo, casasDecimais));
            }

            return (valorAtual, FormatValor(valorAtual, negativo, casasDecimais));
        }

        private static string FormatValor(long valorInterno, bool negativo, int casasDecimais = 2)
        {
            decimal fator = (decimal)Math.Pow(10, casasDecimais);
            decimal valor = (valorInterno / fator) * (negativo ? -1 : 1);
            return valor.ToString($"N{casasDecimais}");
        }
    }
}
