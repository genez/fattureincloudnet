using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class DocLight
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public string Tipo { get; set; }
        public string IdCliente { get; set; }
        public string IdFornitore { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public decimal ImportoNetto { get; set; }
        public decimal ImportoTotale { get; set; }
    }
}
