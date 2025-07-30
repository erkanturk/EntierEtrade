using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; } //Yorumun ait olduğu ürünün kimliği
        public Product Product { get; set; } //Ürün nesnesi ile ilişkilendirme
        public string UserId { get; set; } //Yorumu yapan kullanıcının kimliği
        public DateTime CreateOn { get; set; } //Yorumun oluşturulma tarihi
    }
}
