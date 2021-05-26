namespace Teste.Servicos
{
    public static class FormatarNumeroNaoGeografico
    {
        public static string DeveFormatarNumeroNaoGeografico(string numero)
        {
            if (!EhNumeroNaoGeografico(numero))
            {
                return string.Empty;
            }

            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total != 11)
            {
                return string.Empty;
            }

            string formatado = string.Format("NNG: {0} {1} {2}", num.Substring(0, 4), num.Substring(4, 3), num.Substring(7, 4));

            return formatado;
        }

        private static bool EhNumeroNaoGeografico(string numero)
        {
            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total != 11)
            {
                return false;
            }

            if (num.Substring(0, 4) != "0300" && num.Substring(0, 4) != "0500" && num.Substring(0, 4) != "0800")
            {
                return false;
            }

            return true;
        }
    }
}
