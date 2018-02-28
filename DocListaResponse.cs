using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class DocListaResponse : PagedResponse
    {
        public List<DocLight> ListaDocumenti { get; set; }
    }
}
