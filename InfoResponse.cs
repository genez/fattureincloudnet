using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class InfoResponse : Response
    {
        private static readonly Regex limiteRegex = new Regex("(Rimangono).*?(\\d+).*?(richieste).*?(\\d+).*?(secondi)", RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public string Messaggio { get; set; }
        public string LimiteBreve { get; set; }
        public string LimiteMedio { get; set; }
        public string LimiteLungo { get; set; }

        public int OttieniLimiteBreveQuantita()
        {
            var  m = limiteRegex.Match(LimiteBreve);
            return m.Success ? int.Parse(m.Groups[2].Value) : 0;
        }

        public TimeSpan OttieniLimiteBreveIntervallo()
        {
            var m = limiteRegex.Match(LimiteBreve);
            return m.Success ? TimeSpan.FromSeconds(int.Parse(m.Groups[4].Value)) : TimeSpan.Zero;
        }
    }
}
