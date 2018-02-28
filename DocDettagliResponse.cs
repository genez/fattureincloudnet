using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class DocDettagliResponse
    {
        public bool Success { get; set; }
        public DocDetailed DettagliDocumento { get; set; }
    }
}
