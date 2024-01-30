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
    public class MealMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Ogun");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                .HasColumnName("Ogun_Id")
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnOrder(1);

            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                 .HasColumnName("OgunAdi")
                 .HasMaxLength(50)
                 .IsRequired();

          


        }
    }
}
