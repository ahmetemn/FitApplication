using Di_Station.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.REPO.Context
{
    public class DietContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-12QQ6NC6\AHMET;Database=KD-19-FitApp;Trusted_Connection=True;MultipleActiveResultSets=false;TrustServerCertificate=True;");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Portion> Portions { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<TypeOfFood> TypeOfFoods { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserDetail> UserDetail { get; set; }       

        public DbSet<UserOgunYemekCesidi> UserOgunYemekCesidis { get; set; }

        public DbSet<YemekCesidiPorsiyonOgun> YemekCesidiPorsiyonOguns { get; set; }

        public DbSet<YemekCesidiUrun> YemekCesidiUruns { get; set; }

        public DbSet<YemekKategori> YemekKategoris { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
