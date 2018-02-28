using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class DocDetailed
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string AnnoCompetenza { get; set; }
        public string IdCliente { get; set; }
        public string Nome { get; set; }
        public string IndirizzoVia { get; set; }
        public string IndirizzoCap { get; set; }
        public string IndirizzoCitta { get; set; }
        public string IndirizzoProvincia { get; set; }
        public string IndirizzoExtra { get; set; }
        public string Paese { get; set; }
        public string Lingua { get; set; }
        public string Piva { get; set; }
        public string Cf { get; set; }
        public string Data { get; set; }
        public string ProssimaScadenza { get; set; }
        public string ImportoNetto { get; set; }
        public string ImportoIva { get; set; }
        public string ImportoTotale { get; set; }
        public bool PrezziIvati { get; set; }
        public string Valuta { get; set; }
        public string ValutaCambio { get; set; }
        public string OggettoVisibile { get; set; }
        public string OggettoFattura { get; set; }
        public string OggettoInterno { get; set; }
        public string Note { get; set; }
        public bool NascondiScadenza { get; set; }
        public string Numero { get; set; }
        public string CentroRicavo { get; set; }
        public long Rivalsa { get; set; }
        public long Cassa { get; set; }
        public long RitAcconto { get; set; }
        public long ImponibileRitenuta { get; set; }
        public long RitAltra { get; set; }
        public string ImportoRivalsa { get; set; }
        public string ImportoCassa { get; set; }
        public string ImportoRitAcconto { get; set; }
        public string ImportoRitAltra { get; set; }
        public bool MostraInfoPagamento { get; set; }
        public bool Ddt { get; set; }
        public bool Ftacc { get; set; }
        public string Token { get; set; }
        public string LinkDoc { get; set; }
        public string MarcaBollo { get; set; }
        public string IdTemplate { get; set; }
        public bool MostraBottonePaypal { get; set; }
        public bool MostraBottoneBonifico { get; set; }
        public bool MostraBottoneNotifica { get; set; }
        public bool Pa { get; set; }
        public List<DocPagamento> ListaPagamenti { get; set; }
        public List<DocArticolo> ListaArticoli { get; set; }
    }

    public class DocArticolo
    {
        public string Id { get; set; }
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string Um { get; set; }
        public decimal Quantita { get; set; }
        public string Descrizione { get; set; }
        public string Categoria { get; set; }
        public bool Tassabile { get; set; }
        public bool ApplicaRaContributi { get; set; }
        public decimal PrezzoNetto { get; set; }
        public decimal PrezzoLordo { get; set; }
        public decimal ValoreIva { get; set; }
        public string DescIva { get; set; }
        public decimal Sconto { get; set; }
        public bool InDdt { get; set; }
        public string Ordine { get; set; }
        public string ScontoRosso { get; set; }
    }

    public class DocPagamento
    {
        public string DataScadenza { get; set; }
        public string Metodo { get; set; }
        public string Importo { get; set; }
    }
}
