using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateLimiter;
using RestSharp;

namespace FattureInCloudNet
{
    public class Client
    {
        private readonly string _uid;
        private readonly string _key;
        private readonly RestClient _restClient = null;

        private readonly TimeLimiter _timeconstraint = TimeLimiter.GetFromMaxCountByInterval(1, TimeSpan.FromSeconds(2));

        public Client(string uid, string key)
        {
            _uid = uid;
            _key = key;
            _restClient = new RestClient("https://api.fattureincloud.it/v1");
            SimpleJson.CurrentJsonSerializerStrategy = new SnakeJsonSerializerStrategy();
        }

        public InfoResponse RichiestaInfo()
        {
            var req = new RestRequest("/richiesta/info", Method.POST);
            req.AddJsonBody(new Request { ApiKey = _key, ApiUid = _uid });

            var res = _timeconstraint.Perform(() => _restClient.Execute<InfoResponse>(req));
            res.Wait();

            return res.Result.Data;
        }

        public DocListaResponse ListaFatture(DateTime dataInizio, DateTime dataFine, int? pagina)
        {
            var req = new RestRequest("/fatture/lista", Method.POST);
            req.DateFormat = "dd/MM/yyyy";
            req.AddJsonBody(new ListaFattureRequest {
                ApiKey = _key,
                ApiUid = _uid,
                DataInizio = dataInizio.ToString("dd/MM/yyyy"),
                DataFine = dataFine.ToString("dd/MM/yyyy"),
                Pagina = pagina,
            });

            var res = _timeconstraint.Perform(() => _restClient.Execute<DocListaResponse>(req));
            res.Wait();

            return res.Result.Data;
        }

        public DocListaResponse ListaFattureCompleta(DateTime dataInizio, DateTime dataFine)
        {
            var response = ListaFatture(dataInizio, dataFine, 1);
            while (response.PaginaCorrente < response.NumeroPagine)
            {
                response.PaginaCorrente++;
                var more = ListaFatture(dataInizio, dataFine, response.PaginaCorrente);
                if (response.ListaDocumenti != null && more.ListaDocumenti != null)
                    response.ListaDocumenti.AddRange(more.ListaDocumenti);
            }

            return response;
        }

        public AnagraficaListaResponse ListaAnagrafiche(TipoSoggetto tipoSoggetto, int? pagina)
        {
            var resource = tipoSoggetto == TipoSoggetto.Clienti ? "clienti" : "fornitori";
            var req = new RestRequest($"/{resource}/lista", Method.POST);
            req.AddJsonBody(new ListaSoggettiRequest { ApiKey = _key, ApiUid = _uid, Pagina = pagina});

            var res = _timeconstraint.Perform(() => _restClient.Execute<AnagraficaListaResponse>(req));
            res.Wait();

            return res.Result.Data;
        }

        public AnagraficaListaResponse ListaAnagraficheCompleta(TipoSoggetto tipoSoggetto)
        {
            var response = ListaAnagrafiche(tipoSoggetto, 1);
            while (response.PaginaCorrente < response.NumeroPagine)
            {
                response.PaginaCorrente++;
                var more = ListaAnagrafiche(tipoSoggetto, response.PaginaCorrente);
                if (response.ListaClienti != null && more.ListaClienti != null)
                    response.ListaClienti.AddRange(more.ListaClienti);

                if (response.ListaFornitori != null && more.ListaFornitori != null)
                    response.ListaFornitori.AddRange(more.ListaFornitori);
            }

            return response;
        }

        public DocDettagliResponse DettagliFattura(string token)
        {
            var req = new RestRequest($"/fatture/dettagli", Method.POST);
            req.AddJsonBody(new DettaglioDocumentoRequest { ApiKey = _key, ApiUid = _uid, Token = token });

            var res = _timeconstraint.Perform(() => _restClient.Execute<DocDettagliResponse>(req));
            res.Wait();

            return res.Result.Data;
        }
    }
}
