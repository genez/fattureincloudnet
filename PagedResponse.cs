using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class PagedResponse : Response
    {
        public int PaginaCorrente { get; set; }
        public int NumeroPagine { get; set; }
        public int? NumeroRisultati { get; set; }
        public int? RisultatiPerPagina { get; set; }
    }
}
