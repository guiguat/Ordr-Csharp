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
        public async Task loadRelatorio()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("http://localhost:3333/relatorio")) {
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }
    }
}
