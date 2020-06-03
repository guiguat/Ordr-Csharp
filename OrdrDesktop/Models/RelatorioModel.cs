using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdrDesktop.models
{
    public class RelatorioModel : List<RelatorioItemModel>
    {
        
    }

    public class RelatorioItemModel
    {
        public DateTime DataHora { get; set; }
        public float Debito { get; set; }
        public float Credito { get; set; }
        public float Dinheiro { get; set; }
        public float Total { get; set; }
    }
}
