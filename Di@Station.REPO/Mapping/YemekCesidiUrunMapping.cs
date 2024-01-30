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
    public class YemekCesidiUrunMapping : IEntityTypeConfiguration<YemekCesidiUrun>
    {
        public void Configure(EntityTypeBuilder<YemekCesidiUrun> builder)
        {

            builder.ToTable("YemekCesidiUrun");

            builder.HasKey(x => new { x.YemekCesiId, x.ProductId });


            builder.HasOne(x=>x.TypeOfFood)
                    .WithMany(x=>x.yemekCesidiUruns)
                    .HasForeignKey(x=>x.YemekCesiId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x=>x.Product)
                .WithMany(x=>x.YemekCesidiUruns)
                .HasForeignKey(x=>x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");




        }
    }
}
