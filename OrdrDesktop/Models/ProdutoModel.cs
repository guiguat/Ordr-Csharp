using System;
using System.Collections.Generic;

namespace OrdrDesktop.Models
{
    public class ProdutoModel : List<ProdutoItemModel>
    {

    }

    public class ProdutoItemModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Estoque { get; set; }
        public string Tipo { get; set; }
    }
}
