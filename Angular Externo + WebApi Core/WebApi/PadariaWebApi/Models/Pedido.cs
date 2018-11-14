using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public ICollection<Item> Itens { get; set; }
        public int Preco { get; set; }

        public Pedido()
        {
            Itens = new Collection<Item>();
        }
    }
}
