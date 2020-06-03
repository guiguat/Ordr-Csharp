using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdrDesktop.Models
{
    public class ProdutoModel : List<ProdutoItemModel>
    {

    }

    public class ProdutoItemModel
    {
        public DateTime DataHora { get; set; }
        public float Debito { get; set; }
        public float Credito { get; set; }
        public float Dinheiro { get; set; }
        public float Total { get; set; }
    }
}
