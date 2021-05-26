namespace Teste.Servicos
{
    public static class FormatarTelefoniaFixa
    {
        public static string DeveFormatarTelefoniaFixa(string numero)
        {
            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total == 5 && num.Substring(0, 3) == "103")
                return string.Format("ETF: {0}+{1}", num.Substring(0, 3), num.Substring(3, 2));
            
            return string.Empty;
        }
    }
}
