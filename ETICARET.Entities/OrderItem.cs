using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class OrderItem
    {
        public int Id { get; set; } // Sipariş öğesinin benzersiz kimliği
        public int OrderId { get; set; }
        public Order Order { get; set; } // Sipariş nesnesi ile ilişkilendirme
        public Product Product { get; set; } // Ürün nesnesi ile ilişkilendirme
        public int ProductId { get; set; } // Sipariş öğesinin ait olduğu ürünün kimliği
        public decimal Price { get; set; } // Sipariş öğesinin fiyatı
        public int Quantity { get; set; } // Sipariş öğesinin miktarı
    }
}
