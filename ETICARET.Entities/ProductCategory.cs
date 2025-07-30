using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class ProductCategory
    {
        public int CategoryId { get; set; } // Kategori kimliği
        public Category Category { get; set; } // Kategori nesnesi ile ilişkilendirme
        public int ProductId { get; set; } // Ürün kimliği
        public Product Product { get; set; } // Ürün nesnesi ile ilişkilendirme
    }
}
