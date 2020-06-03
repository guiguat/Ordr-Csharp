using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrdrDesktop.Models
{
    class CozinhaProcessor
    {
        public static async Task<CozinhaModel> getPedidos()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{ApiHelper.baseUrl}/pedido"))
            {
                if (response.IsSuccessStatusCode)
                {
                    CozinhaModel relatorio = await response.Content.ReadAsAsync<CozinhaModel>();
                    return relatorio;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
    class CozinhaModel : List<CozinhaItemModel>
    {

    }

    class CozinhaItemModel
    {
        public int Id {get;set;}
        public int Mesa { get; set; }
        public string Pedidos { get; set; }

    }
}
