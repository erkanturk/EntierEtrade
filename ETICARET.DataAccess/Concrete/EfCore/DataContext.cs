using ETICARET.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.DataAccess.Concrete.EfCore
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=OGRETMEN\MSSQLSERVER01;Database=ETICARET;uid=sa;pwd=1;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ProductCategory tablosunda birleşik anahtar tanımlıyoruz 
            modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.ProductId, c.CategoryId });
        }
        public DbSet<Product> Products { get; set; } //Ürünler tablosu
        public DbSet<Category> Categories { get; set; } //Kategoriler tablosu
        public DbSet<Image> Images { get; set; } //Resimler tablosu
        public DbSet<Comment> Comments { get; set; } //Yorumlar tablosu
        public DbSet<Cart> Carts { get; set; } //Sepetler tablosu
        public DbSet<Order> Orders { get; set; } //Siparişler tablosu
    }
}
