using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PadariaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.DatabaseResources
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => new { i.PedidoId, i.ProdutoId });

            builder.HasOne(i => i.Pedido)
                .WithMany(p => p.Itens)
                .HasForeignKey(i => i.PedidoId);

            builder.HasOne(i => i.Produto)
                .WithMany(p => p.Itens)
                .HasForeignKey(i => i.ProdutoId);
        }
    }
}
