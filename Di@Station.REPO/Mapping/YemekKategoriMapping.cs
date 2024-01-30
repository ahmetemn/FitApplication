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
    public class YemekKategoriMapping : IEntityTypeConfiguration<YemekKategori>
    {
        public void Configure(EntityTypeBuilder<YemekKategori> builder)
        {

            builder.ToTable("YemekKategori");

           
            builder.HasKey(x => new { x.ID, x.KategoriId, x.YemekCesidi_Id });

            builder.Property(x => x.ID)
                .HasColumnOrder(1)
                .HasColumnName("Id")
                .IsRequired()
                .HasColumnType("integer");

            builder.HasOne(x=>x.Category)
                .WithMany(x=>x.YemekKategoris)
                .HasForeignKey(x=>x.KategoriId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x => x.TypeOfFood)
              
                  .WithMany(x => x.YemekKategoris)
                  .HasForeignKey(x => x.YemekCesidi_Id)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.YemekCesidi_Id).IsUnique();


            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");





        }
    }
}
