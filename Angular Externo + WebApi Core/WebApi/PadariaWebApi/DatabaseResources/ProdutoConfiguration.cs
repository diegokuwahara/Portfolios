using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PadariaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.DatabaseResources
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder )
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired();           

            builder.HasOne(p => p.CategoriaProduto)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaProdutoId);
        }

    }
}
