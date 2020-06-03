using OrdrDesktop.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrdrDesktop
{
    public class ProdutoProcessor
    {
        public static async Task<ProdutoModel> getProdutos()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("http://localhost:3333/produto"))
            {
                if (response.IsSuccessStatusCode)
                {
                    ProdutoModel relatorio = await response.Content.ReadAsAsync<ProdutoModel>();
                    return relatorio;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        //public static async Task<RelatorioModel> openRelatorio()
        //{
        //    HttpContent falseData = null;
        //    using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync("http://localhost:3333/relatorio", falseData))
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            RelatorioModel relatorio = await response.Content.ReadAsAsync<RelatorioModel>();
        //            return relatorio;
        //        }
        //        else
        //        {
        //            throw new Exception(response.ReasonPhrase);
        //        }
        //    }
        //}
    }
}
