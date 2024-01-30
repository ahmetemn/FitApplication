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
    public class YemekCesidiPorsiyonOgunMapping : IEntityTypeConfiguration<YemekCesidiPorsiyonOgun>
    {
        public void Configure(EntityTypeBuilder<YemekCesidiPorsiyonOgun> builder)
        {
            builder.ToTable("YemekCesidiPorsiyonOgun");


           
            //builder.HasKey(x => new { x.ID, x.YemekCesidi_ID, x.Porsiyon_Id, x.OgunId });
            builder.HasKey(x => x.ID );

            builder.Property(x => x.ID)
                .HasColumnName("YemekCesidiPorsiyonOgun_Id ")
                .HasColumnType("integer")
                .HasColumnOrder(1)
                .UseIdentityColumn();

            builder.HasOne(x=>x.TypeOfFood)
                .WithMany(x=>x.YemekCesidiPorsiyonOguns)
                .HasForeignKey(x=>x.YemekCesidi_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x=>x.Portion)
                .WithMany(x=>x.YemekCesidiPorsiyonOguns)
                .HasForeignKey(x=>x.Porsiyon_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x=>x.Meal)
                .WithMany(x=>x.YemekCesidiPorsiyonOguns)
                .HasForeignKey(x=>x.OgunId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");




        }
    }
}
