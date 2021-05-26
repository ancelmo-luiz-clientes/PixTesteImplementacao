namespace Teste.Servicos
{
    public static class FormatarTelefoneResidencial
    {
        public static string DeveFormatarNumeroResidencial(string numero)
        {
            string num = numero.Replace(" ", "");

            if (!EhTelefoneResidencial(num))
            {
                return string.Empty;
            }

            string numFormatado = string.Empty;
            int total = num.Length;

            switch (total)
            {
                case 8:
                    numFormatado = string.Format("RES: {0}-{1}", num.Substring(0, 4), num.Substring(4, 4));
                    break;
                case 10:
                    numFormatado = string.Format("RES: ({0}) {1}-{2}", num.Substring(0, 2), num.Substring(2, 4), num.Substring(6, 4));
                    break;
                case 11:
                    numFormatado = string.Format("RES: ({0}) {1}-{2}", num.Substring(1, 2), num.Substring(3, 4), num.Substring(7, 4));
                    break;
                case 12:
                    numFormatado = string.Format("RES: +{0} ({1}) {2}-{3}", num.Substring(0, 2), num.Substring(2, 2), num.Substring(4, 4), num.Substring(8, 4));
                    break;
            }

            return numFormatado;
        }

        private static bool EhTelefoneResidencial(string numero)
        {
            int total = numero.Length;
            switch (total)
            {
                case 8:
                    if (numero.Substring(0, 1) != 2.ToString() && numero.Substring(0, 1) != 3.ToString() && numero.Substring(0, 1) != 4.ToString() && numero.Substring(0, 1) != 5.ToString())
                        return false;
                    break;
                case 10:
                    if (numero.Substring(2, 1) != 2.ToString() && numero.Substring(2, 1) != 3.ToString() && numero.Substring(2, 1) != 4.ToString() && numero.Substring(2, 1) != 5.ToString())
                        return false;
                    break;
                case 11:
                    if (numero.Substring(3, 1) != 2.ToString() && numero.Substring(3, 1) != 3.ToString() && numero.Substring(3, 1) != 4.ToString() && numero.Substring(3, 1) != 5.ToString())
                        return false;
                    break;
                case 12:
                    if (numero.Substring(4, 1) != 2.ToString() && numero.Substring(4, 1) != 3.ToString() && numero.Substring(4, 1) != 4.ToString() && numero.Substring(4, 1) != 5.ToString())
                        return false;
                    break;
            }
            return true;
        }

    }
}
