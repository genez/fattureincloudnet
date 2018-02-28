using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    internal class DettaglioDocumentoRequest : Request
    {
        public string Id { get; set; }
        public string Token { get; set; }
    }
}
