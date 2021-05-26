namespace Teste.Servicos
{
    public static class FormatarTelefoniaMovel
    {
        public static string DeveFormatarTelefoniaMovel(string numero)
        {
            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total != 4)
                return string.Empty;

            return string.Format("ETM: {0}", num.Substring(0, 4));
        }
    }
}
