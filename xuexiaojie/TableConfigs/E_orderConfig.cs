using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xuexiaojie.Models;

namespace xuexiaojie.TableConfigs
{
    public class E_orderConfig : IEntityTypeConfiguration<E_order>
    {
        public void Configure(EntityTypeBuilder<E_order> builder)
        {
            builder.ToTable("E_order");//表对应关系
            builder.Property(p => p.TotalAmount).HasColumnType("float(10,2)").IsRequired();
            builder.Property(p => p.TotalQuantity).HasMaxLength(7).IsRequired();
        }
    }
}
