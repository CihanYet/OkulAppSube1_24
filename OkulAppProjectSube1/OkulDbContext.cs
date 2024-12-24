using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfApp
{
    internal class OkulDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulDbSube1Proje;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        }
    }
}

//DbContext classı: EF içerisinde veritabanı  işlemlerini yapmak için kullanılan class. Örn. CRUD işlemleri. Her projenin ayrı bir DbContext classı olmalıdır. Her projenin DB'si kendisine özgüdür.

//DbSet: DB'deki tabloları bellekte temsil eder. Generic yapılardır. Dolayısla hangi entity tipinde oluşturulursa, o tipteki alanları içerir. Db için sorguları çalıştırmak için kullanılır. Entity'ler bu yapı içerisinde tutulur. Örn. Ogrenci tipi için, OgrenciId, Ad,Soyad,Numara


//Migration Classları: EF Code First tekniğinde, kod ile yapılan işlemlerin DB'ye aktarılması için gerekli olan classlardır. Bu classlar her kod değişiminde oluşturulmalıdır. Migration class'ı oluşturmak için add-migration komutu kullanılır.