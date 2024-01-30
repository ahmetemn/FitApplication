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
    public class UserOgunYemekCesitTablosu : IEntityTypeConfiguration<UserOgunYemekCesidi>
    {
        public void Configure(EntityTypeBuilder<UserOgunYemekCesidi> builder)
        {

            builder.ToTable("UserOgunYemekCesit");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .HasColumnName("UserOgunYemekCesidiId")
                .HasColumnType("integer")
                .HasColumnOrder(1)
                .UseIdentityColumn();

            // YemekCesidiPorsiyonOgun ile olan ilişkiyi belirtme
            builder.HasOne(x => x.YemekCesidiPorsiyonOgun)
                .WithMany()
                .HasForeignKey(x => x.YemekCesidiPorsiyonOgun_Id)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");





        }
    }
}
