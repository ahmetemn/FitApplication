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
    public class UserDetailMapping : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {

            builder.Property(x => x.Gender)
       .HasColumnName("Cinsiyet")
       .IsRequired()  //boş geçilemez 

                .HasColumnType("bit");

            builder.Property(x => x.BirthDate)
             .HasColumnName("DogumTarihi")
             .IsRequired()  //boş geçilemez 

             .HasColumnType("datetime");

            //.HasComputedColumnSql => burası sadece kodla yükleyince olur 

            builder.Property(x => x.Age)
             .HasColumnName("Yas")
             .HasComputedColumnSql("DATEDIFF(YEAR, DogumTarihi, GETDATE())")
             .IsRequired()  //boş geçilemez 

             .HasColumnType("int"); 

           
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("GETDATE()"); // Create
            builder.Property(p => p.UpdatedDate).HasDefaultValueSql("GETDATE()"); // Create


            builder.Property(x => x.Weight)
           .HasColumnName("Kilo")
           .IsRequired()  //boş geçilemez 

           .HasColumnType("decimal(18,2)"); 



            builder.Property(x => x.Height)
           .HasColumnName("Boy")
           .IsRequired()  //boş geçilemez 

           .HasColumnType("decimal(18,2)"); 
            builder.Property(x => x.City)
              .HasColumnName("Sehir")
              .IsRequired()  //boş geçilemez 
              .HasMaxLength(20)
              .HasColumnType("nvarchar"); 


            builder.Property(x => x.Job)
             .HasColumnName("Meslek")
             .IsRequired()  //boş geçilemez 
             .HasMaxLength(60)
             .HasColumnType("nvarchar"); //daha geniş vezaman tari




            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");




        }
    }
}
