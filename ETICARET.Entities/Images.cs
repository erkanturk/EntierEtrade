using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    [Table("Image")]
    public class Images
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; } // Resim URL'si
        public int ProductId { get; set; } // Resmin ait olduğu ürünün kimliği
        public Product Product { get; set; } // Ürün nesnesi ile ilişkilendirme

    }
}
