using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(250");
            
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(250");

            builder.Property(p => p.Imagem)
                .IsRequired()
                .HasColumnType("varchar(250");

            builder.OwnsOne(p => p.Dimensoes, dm =>
            {
                dm.Property(c => c.Altura)
                    .HasColumnName("Altura")
                    .HasColumnType("int");

                dm.Property(c => c.Largura)
                    .HasColumnName("Largura")
                    .HasColumnType("int");

                dm.Property(c => c.Profundidade)
                    .HasColumnName("Profundidade")
                    .HasColumnType("int");
            });

            builder.ToTable("Produtos");
        }
    }
}
