using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public float Preco { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
        public int CategoriaProdutoId { get; set; }
        public ICollection<Item> Itens { get; set; }

        public Produto()
        {
            Itens = new Collection<Item>();
        }
    }
}
