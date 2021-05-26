namespace Teste.Servicos
{
    public static class FormatarTelefoneCelular
    {
        public static string DeveFormatarNumeroCelular(string numero)
        {
            string num = numero.Replace(" ", "");
            if (!EhTelefoneCelular(num))
            {
                return string.Empty;
            }

            string numFormatado = string.Empty;
            int total = num.Length;

            switch (total)
            {
                case 8:
                    numFormatado = string.Format("MOB: {0}-{1}", num.Substring(0, 4), num.Substring(4, 4));
                    break;
                case 9:
                    numFormatado = string.Format("MOB: {0} {1}-{2}", num.Substring(0, 1), num.Substring(1, 4), num.Substring(5, 4));
                    break;
                case 10:
                    numFormatado = string.Format("MOB: ({0}) {1}-{2}", num.Substring(0, 2), num.Substring(2, 4), num.Substring(6, 4));
                    break;
                case 11:
                    if (num.Substring(0, 1) == "0")
                        numFormatado = string.Format("MOB: ({0}) {1}-{2}", num.Substring(1, 2), num.Substring(3, 4), num.Substring(7, 4));
                    else
                        numFormatado = string.Format("MOB: ({0}) {1} {2}-{3}", num.Substring(0, 2), num.Substring(2, 1), num.Substring(3, 4), num.Substring(7, 4));
                    break;
                case 12:
                    if (num.Substring(0, 1) == "0")
                        numFormatado = string.Format("MOB: ({0}) {1} {2}-{3}", num.Substring(1, 2), num.Substring(3, 1), num.Substring(4, 4), num.Substring(8, 4));
                    else
                        numFormatado = string.Format("MOB: +{0} ({1}) {2}-{3}", num.Substring(0, 2), num.Substring(2, 2), num.Substring(4, 4), num.Substring(8, 4));
                    break;
                case 13:
                    numFormatado = string.Format("MOB: +{0} ({1}) {2} {3}-{4}", num.Substring(0, 2), num.Substring(2, 2), num.Substring(4, 1), num.Substring(5, 4), num.Substring(9, 4));
                    break;
            }

            return numFormatado;
        }

        private static bool EhTelefoneCelular(string numero)
        {
            int total = numero.Length;
            switch (total)
            {
                case 8:
                    if (numero.Substring(0, 1) != 7.ToString() && numero.Substring(0, 1) != 8.ToString() && numero.Substring(0, 1) != 9.ToString())
                        return false;
                    break;
                case 9:
                    if (numero.Substring(1, 1) != 7.ToString() && numero.Substring(1, 1) != 8.ToString() && numero.Substring(1, 1) != 9.ToString())
                        return false;
                    break;
                case 10:
                    if (numero.Substring(2, 1) != 7.ToString() && numero.Substring(2, 1) != 8.ToString() && numero.Substring(2, 1) != 9.ToString())
                        return false;
                    break;
                case 11:
                    if (numero.Substring(3, 1) != 7.ToString() && numero.Substring(3, 1) != 8.ToString() && numero.Substring(3, 1) != 9.ToString())
                        return false;
                    break;
                case 12:
                    if (numero.Substring(4, 1) != 7.ToString() && numero.Substring(4, 1) != 8.ToString() && numero.Substring(4, 1) != 9.ToString())
                        return false;
                    break;
                case 13:
                    if (numero.Substring(5, 1) != 7.ToString() && numero.Substring(5, 1) != 8.ToString() && numero.Substring(5, 1) != 9.ToString())
                        return false;
                    break;
            }
            return true;
        }

    }
}
