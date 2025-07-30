using ETICARET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        void DeleteFromCategory(int categoryId, int productId); // Belirtilen ürünü kategoriden siler
        Category GetByIdWithProducts(int id); // Belirtilen kategori ID'sine sahip kategoriyi ve ilişkili ürünleri getirir
    }
}
