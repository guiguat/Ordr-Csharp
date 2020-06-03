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
        public static async Task<string> deletePedido(int id)
        {
            var pedido = new CozinhaItemModel();
            pedido.Id = id;
            Console.WriteLine(pedido.Id);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync($"{ApiHelper.baseUrl}/pedido?id={pedido.Id}"))
            {
                if (response.IsSuccessStatusCode)
                {   
                    return "OK";
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
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
