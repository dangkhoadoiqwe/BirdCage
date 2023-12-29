using DataAccess;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public class ProductReponsitory : IProductReponsitory
    {
        public void AddProduct(Product product) => ProductDao.AddPro(product);

        

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getallpro() => ProductDao.GetallProduct();

        public void UpdateProduct(Product product)
        {
            ProductDao.UpdatePro(product);
        }

        
    }
}
