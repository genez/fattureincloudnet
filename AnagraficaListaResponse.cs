using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class AnagraficaListaResponse : PagedResponse
    {
        public List<AnagraficaCliente> ListaClienti { get; set; }
        public List<AnagraficaFornitore> ListaFornitori { get; set; }
    }

    public abstract class Anagrafica
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Referente { get; set; }
        public string IndirizzoVia { get; set; }
        public string IndirizzoCap { get; set; }
        public string IndirizzoCitta { get; set; }
        public string IndirizzoProvincia { get; set; }
        public string IndirizzoExtra { get; set; }
        public string Paese { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Piva { get; set; }
        public string Cf { get; set; }
        public string Extra { get; set; }
    }

    public class AnagraficaFornitore : Anagrafica
    {
    }

    public class AnagraficaCliente : Anagrafica
    {
        public int TerminiPagamento { get; set; }
        public bool PagamentoFineMese { get; set; }
        public string ValIvaDefault { get; set; }
        public string DescIvaDefault { get; set; }
        public bool Pa { get; set; }
        public string PaCodice { get; set; }
    }
}
