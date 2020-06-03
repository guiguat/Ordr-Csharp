using Newtonsoft.Json;
using OrdrDesktop.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrdrDesktop
{
    public class ProdutoProcessor
    {
        public static async Task<ProdutoModel> getProdutos()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{ApiHelper.baseUrl}/produto"))
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
        public static async Task<string> createProduto(string nome, float preco, int estoque, string tipo)
        {
            var produto = new ProdutoCreateModel();
            produto.nome = nome;
            produto.preco = preco;
            produto.estoque = estoque;
            produto.tipo = tipo;
            var json = JsonConvert.SerializeObject(produto);
            Console.WriteLine(json.ToString());
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync($"{ApiHelper.baseUrl}/produto", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    return "OK";
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<string> editProduto(int id, string nome, float preco, int estoque, string tipo)
        {
            var produto = new ProdutoCreateModel();
            produto.id = id;
            produto.nome = nome;
            produto.preco = preco;
            produto.estoque = estoque;
            produto.tipo = tipo;
            var json = JsonConvert.SerializeObject(produto);
            Console.WriteLine(json.ToString());
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync($"{ApiHelper.baseUrl}/produto", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    return "OK";
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public static async Task<string> estoqueProduto(int id, int estoque)
        {
            var produto = new ProdutoCreateModel();
            produto.id = id;
            produto.estoque = estoque;
            var json = JsonConvert.SerializeObject(produto);
            Console.WriteLine(json.ToString());
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync($"{ApiHelper.baseUrl}/produto/estoque", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    return "OK";
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
