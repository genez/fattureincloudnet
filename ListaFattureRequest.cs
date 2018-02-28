using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    internal class ListaFattureRequest : Request
    {
        public string DataInizio { get; set; }
        public string DataFine { get; set; }
        public int? Pagina { get; set; } 
    }
}
