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
    public class PortionMapping : IEntityTypeConfiguration<Portion>
    {
        public void Configure(EntityTypeBuilder<Portion> builder)
        {

            builder.ToTable("Porsiyon");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .HasColumnName("Porsiyon_Id")
                .HasColumnType("int")
                .UseIdentityColumn()
                .HasColumnOrder(1);


            builder.Property(x => x.Scale)
                .IsRequired()
                .HasColumnName("PorsiyonOlcegi")
                .HasColumnType("decimal(18,2)");


            builder.Property(x => x.Status)
               .HasColumnName("Status")
               .IsRequired()  //boş geçilemez 
               .HasMaxLength(20)
               .HasColumnType("nvarchar");




        }
    }
}
