using OrdrDesktop.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrdrDesktop
{
    public class RelatorioProcessor
    {
        public static async Task<RelatorioModel> loadRelatorio()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("http://localhost:3333/relatorio")) {
                if (response.IsSuccessStatusCode)
                {
                    RelatorioModel relatorio = await response.Content.ReadAsAsync<RelatorioModel>();
                    return relatorio;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public static async Task<RelatorioModel> openRelatorio()
        {
            HttpContent falseData = null;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync("http://localhost:3333/relatorio", falseData))
            {
                if (response.IsSuccessStatusCode)
                {
                    RelatorioModel relatorio = await response.Content.ReadAsAsync<RelatorioModel>();
                    return relatorio;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
