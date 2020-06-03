using OrdrDesktop.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrdrDesktop
{
    public class RelatorioProcessor
    {
        public static async Task<RelatorioModel> loadRelatorio()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{ApiHelper.baseUrl}/relatorio")) {
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
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync($"{ApiHelper.baseUrl}/relatorio", falseData))
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
