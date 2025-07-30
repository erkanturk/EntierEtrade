using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }//Ürün nesnesi ile ilişkilendirme
        public Cart Cart { get; set; }//Sepet nesnesi ile ilişkilendirme
        public int CartId { get; set; }//sepet kimliği navigation property
        public int Quantity { get; set; }
    }
}
