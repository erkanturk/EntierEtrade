using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class Product
    {
        public int Id { get; set; } // Ürünün benzersiz kimliği
        public string Name { get; set; } // Ürünün adı
        public string Description { get; set; } // Ürünün açıklaması
        public List<Images> Images { get; set; } // Ürüne ait resimler
        [Range(0, double.MaxValue, ErrorMessage = "Fiyat geçerli bir değer olmalı")]
        public decimal Price { get; set; } // Ürünün fiyatı
        public List<ProductCategory> ProductCategories { get; set; } // Ürünün ait olduğu kategoriler
        public List<Comment> Comments { get; set; } // Ürüne ait yorumlar
        public Product()
        {
            Images = new List<Images>();
            ProductCategories = new List<ProductCategory>();
            Comments = new List<Comment>();
        }
    }
}
