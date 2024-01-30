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
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Kullanıcılar");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .HasColumnName("User_Id")
                .HasColumnType("int")
                .UseIdentityColumn()
                .HasColumnOrder(1);

            builder.Property(x => x.UserName)
                .HasColumnName("KullaniciAdi")
                .IsRequired()  //boş geçilemez 
                .HasMaxLength(50)
                .HasColumnType("nvarchar");


            builder.Property(x => x.Password)
              .HasColumnName("KullaniciSifre")
              .IsRequired()  //boş geçilemez 
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            builder.Property(x => x.FirstName)
            .HasColumnName("Ad")
            .IsRequired()  //boş geçilemez 
            .HasMaxLength(50)
            .HasColumnType("nvarchar");


            builder.Property(x => x.LastName)
              .HasColumnName("Soyad")
              .IsRequired()  //boş geçilemez 
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            builder.Property(x => x.Email)
            .HasColumnName("Email")
            .IsRequired()  //boş geçilemez 
            .HasMaxLength(50)
            .HasColumnType("nvarchar");


            builder.HasMany(x => x.UserOgunYemekCesidis)
               .WithOne(x => x.User)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            

            builder.HasOne(x=>x.UserDetail)
                .WithOne(u=>u.User)
                .HasForeignKey<User>(d=>d.UserDetailId)
                .OnDelete(DeleteBehavior.Restrict);




            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");




        }
    }
}
