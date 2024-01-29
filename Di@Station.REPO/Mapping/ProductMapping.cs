using Di_Station.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.REPO.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Urunler");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .HasColumnName("Urun_Id")
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnOrder(1);


            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasColumnName("UrunAdi")
                .HasMaxLength(100);


            builder.Property(x => x.Calorie)
                .IsRequired()
                  .HasColumnType("decimal(18,2)")
                  .HasColumnName("Kalori");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("money")
                .HasColumnName("Fiyat");


        }
    }
}
