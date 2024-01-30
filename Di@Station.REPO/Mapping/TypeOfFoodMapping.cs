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
    public class TypeOfFoodMapping : IEntityTypeConfiguration<TypeOfFood>
    {

        public void Configure(EntityTypeBuilder<TypeOfFood> builder)
        {

            builder.ToTable("Yemek Cesidi");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .HasColumnName("YemekCesidi_ID")
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnOrder(1);


            builder.Property(x => x.MenuName)
                .HasColumnType("nvarchar")
                .HasColumnName("YemekAdi")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(x => x.Kalori)
            .HasColumnType("decimal(18,2)")
            .HasColumnName("Kalori")
            .IsRequired();

            builder.Property(x => x.Fiyat)
                       .HasColumnType("decimal(18,2)")
                       .HasColumnName("Fiyat")
                       .IsRequired();



        }
    }
}
