namespace Teste.Servicos
{
    public static class FormatarSup
    {
        public static string DeveFormatarSUP(string numero)
        {
            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total != 3)
            {
                return string.Empty;
            }
            return string.Format("SUP: {0}", num.Substring(0, 3));
        }
    }
}
