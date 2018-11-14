using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PadariaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebApi.DatabaseResources
{
    public class CategoriaProdutoConfiguration : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired();

        }
    }
}
