using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Entities
{
    public class Order
    {
        public int Id { get; set; } // Siparişin benzersiz kimliği
        public string OrderNumber { get; set; } // Sipariş numarası
        public DateTime OrderDate { get; set; } // Siparişin verildiği tarih
        public string UserId { get; set; } // Siparişi veren kullanıcının kimliği
        public string FirstName { get; set; } // Kullanıcının adı
        public string LastName { get; set; } // Kullanıcının soyadı
        public string Address { get; set; } // Kullanıcının adresi
        public string City { get; set; } // Kullanıcının şehri
        public string Phone { get; set; } // Kullanıcının telefon numarası
        public string Email { get; set; } // Kullanıcının e-posta adresi
        public string OrderNote { get; set; } // Sipariş notu
        public string PaymentId { get; set; } // Ödeme yöntemi kimliği
        public string PaymentToken { get; set; } // Ödeme yöntemi belirteci
        public string ConversionId { get; set; } // Siparişin iletişim kimliği
        public EnumOrderState OrderState { get; set; } // Sipariş durumu
        public EnumPaymentTypes PaymentTypes { get; set; } // Ödeme türü
        public List<OrderItem> OrderItems { get; set; } // Sipariş öğeleri


        public Order()
        {
            OrderItems=new List<OrderItem>(); // Sipariş öğeleri listesini başlat
        }

    }
    public enum EnumOrderState
    {
        waiting = 0, // Beklemede
        unpaid = 1, // Ödenmemiş
        completed = 2, // Tamamlanmış
    }
    public enum EnumPaymentTypes
    {
        CreditCard = 0, // Kredi Kartı
        Eft=1, // EFT

    }
}
