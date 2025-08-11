using ETICARET.DataAccess.Abstract;
using ETICARET.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.DataAccess.Concrete.EfCore
{
    public class EfCoreCartDal : EfCoreGenericRepository<Cart, DataContext>, ICartDal
    {
        public void ClearCart(string cartId)
        {
            using (var context = new DataContext())
            {
                var cmd = @"delete from CartItem where CartId=@p0";
                context.Database.ExecuteSqlRaw(cmd, cartId);
            }
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context = new DataContext())
            {
                var cmd = @"delete from CartItem where CartId=@p0 and ProductId=@p1";
                context.Database.ExecuteSqlRaw(cmd, cartId, productId);
            }
        }
        //Kullanıcının sepet içeriğini getiren method.
        public Cart GetCartByUserId(string userId)
        {
            using (var context = new DataContext())
            {
                return context.Carts
                    .Include(i => i.CartItems)//Sepetteki ürünleri dahil et carts tarafına bağlan
                    .ThenInclude(i => i.Product)//Cartsİtems tarafından product a bağlan ve ürün bilgilerini dahil et
                    .ThenInclude(i => i.Images)//ürün resimlerini dahil et
                    .FirstOrDefault(i => i.UserId==userId);//kullanıcı bazında getir.
            }
        }
        public override void Update(Cart entity)
        {//Ana sınıfta virtual olduğu için bu alanda ezmeye tabi tuttuk.
            using (var context = new DataContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
/*
1️ Include(i => i.OrderItems)
Amaç: Sipariş içindeki ürünleri (OrderItems) de çekmek.
Neden? Eğer Include kullanılmazsa, yalnızca Orders tablosundaki temel sipariş bilgileri gelir. Siparişe ait ürünlerin listesi lazy loading nedeniyle null kalabilir veya ekstra sorgularla çağrılması gerekebilir. Bu yüzden doğrudan siparişe ait ürünleri dahil ediyoruz.
2️ ThenInclude(i => i.Product)
Amaç: Sipariş içindeki ürünlerin detaylarını da (Product) çekmek.
Neden? Eğer OrderItems içinde sadece ProductId gibi yabancı anahtarları çağırırsak, ürünün tüm detaylarını (isim, açıklama, fiyat vb.) göremeyiz.
Çözüm: ThenInclude kullanarak her sipariş ürününe ait Product bilgisini de getiriyoruz.
3️ ThenInclude(i => i.Images)
Amaç: Sipariş içindeki ürünlerin resimlerini de (Images) dahil etmek.
Neden? Eğer bir ürünün görselleri Product içinde saklanıyorsa, siparişteki ürünleri gösterirken ürüne ait resimleri de göstermek için bu bilgiyi dahil etmemiz gerekir.
4️ AsQueryable()
Amaç: LINQ işlemlerine devam edebilmek için sorgunun LINQ tarafından yönetilebilir hale getirilmesi.
Neden? AsQueryable() kullanılmazsa, veriler doğrudan veritabanından çekilip bir listeye dönüştürülür (ToList()). Ancak burada filtreleme (Where) işlemi yapılacağı için sorgunun veritabanına gönderilmeden önce LINQ tarafından yönetilebilmesini sağlıyoruz.
5️ Where(i => i.UserId == userId)
Amaç: Eğer userId parametresi boş değilse, yalnızca ilgili kullanıcıya ait siparişleri getir.
Neden? Eğer Where kullanmazsak, tüm siparişler getirilir. Ancak burada yalnızca belirli bir kullanıcıya ait siparişleri listelemek istediğimiz için filtreleme yapıyoruz.
*/