using ETICARET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        int GetCountByCategory(string category); // Belirtilen kategori ID'sine sahip ürün sayısını getirir
        Product GetProductDetails(int id); // Belirtilen ürün ID'sine sahip ürünün detaylarını getirir
        List<Product> GetProductsByCategory(string category, int page, int pageSize);//Sayfalama ile belirli bir kategoriye ait ürünleri getirir 
        void Update(Product entity, int[] categoryIds);//Ürünü ve ona bağlı kategorileri günceller
    }
}
