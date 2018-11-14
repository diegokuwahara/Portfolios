using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.Models
{
    public class Item
    {
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
    }
}
