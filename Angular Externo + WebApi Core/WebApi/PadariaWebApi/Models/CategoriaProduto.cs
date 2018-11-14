using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.Models
{
    public class CategoriaProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
