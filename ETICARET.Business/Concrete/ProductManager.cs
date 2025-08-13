using ETICARET.Business.Abstract;
using ETICARET.DataAccess.Abstract;
using ETICARET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Create(Product product)
        {
            _productDal.Create(product);
        }

        public void Delete(Product product)
        {
           _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
           return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
           return _productDal.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
           return _productDal.GetCountByCategory(category);
        }

        public List<Product> GetProductByCategory(string category, int page, int pageSize)
        {
           return _productDal.GetProductsByCategory(category, page, pageSize);
        }

        public Product GetProductDetail(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public void Update(Product product, int[] categoryIds)
        {
            _productDal.Update(product, categoryIds);
        }
    }
}
