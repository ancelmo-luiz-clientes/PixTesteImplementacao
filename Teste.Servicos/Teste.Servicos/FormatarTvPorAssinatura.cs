using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Servicos
{
    public static class FormatarTvPorAssinatura
    {
        public static string DeveFormatarTvPorAssinatura(string numero)
        {
            string num = numero.Replace(" ", "");
            int total = num.Length;

            if (total == 5 && num.Substring(0, 3) == "106")
                return string.Format("ETV: {0}", num.Substring(0, 5));

            return string.Empty;
        }
    }
}
