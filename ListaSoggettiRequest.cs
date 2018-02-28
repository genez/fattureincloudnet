using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    internal class ListaSoggettiRequest : Request
    {
        public string Filtro { get; set; }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cf { get; set; }
        public string Piva { get; set; }
        public int? Pagina { get; set; }
    }
}
