using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Vendas.Domain;

namespace NerdStore.Vendas.Data.Mapping
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ProdutoNome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // 1 : N => Pedido : Pagamento

            builder.HasOne(c => c.Pedido)
                .WithMany(c => c.PedidoItens);

            builder.ToTable("PedidoItens");
        }
    }
}
