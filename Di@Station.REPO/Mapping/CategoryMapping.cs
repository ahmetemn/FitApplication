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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           
            builder.ToTable("Kategori");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                .HasColumnName("Kategori_Id")
                .HasColumnType("integer")
                .UseIdentityColumn()
                .HasColumnOrder(1);


            builder.Property(x => x.CategoryName)
                .HasColumnName("KategoriAdi")
                .IsRequired()  //boş geçilemez 
                .HasMaxLength(50)
                .HasColumnType("nvarchar");



        

        }
    }
}
