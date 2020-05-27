using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdrDesktop.models
{
    public class RelatorioModel
    {
        public List<RelatorioItemModel> relatorios { get; set; }
    }

    public class RelatorioItemModel
    {
        public string DataHora { get; set; }
        public float Debito { get; set; }
        public float Credito { get; set; }
        public float Dinheiro { get; set; }
        public float Total { get; set; }

    }
}
