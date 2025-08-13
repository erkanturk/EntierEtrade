using ETICARET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetProductByCategory(string category, int page, int pageSize);
        List<Product> GetAll();
        Product GetProductDetail(int id);
        void Create(Product product);
        void Update(Product product, int[] categoryIds);
        void Delete(Product product);
        int GetCountByCategory(string category);

    }
}
