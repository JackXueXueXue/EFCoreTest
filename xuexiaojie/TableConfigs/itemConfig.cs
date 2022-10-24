using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xuexiaojie.Models;

namespace xuexiaojie.TableConfigs
{
    public class itemConfig : IEntityTypeConfiguration<item>
    {
        public void Configure(EntityTypeBuilder<item> builder)
        {
            builder.ToTable("item");//表对应关系
            builder.Property(p => p.title).HasMaxLength(200).IsRequired();
            builder.Property(p => p.price).HasColumnType("float(10,2)").IsRequired();
            builder.Property(p => p.num).HasMaxLength(7).IsRequired();
        }
    }
}
