using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDao
    {
        public static void DeletPro(int ProductID)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    var exisit = context.Products.SingleOrDefault(p => p.ProductId == ProductID);
                    if (exisit != null)
                    {
                        context.Products.Remove(exisit);
                        context.SaveChanges();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product: " + ex.Message);
            }
        }
        public static void UpdatePro(Product product)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    var existing = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                    if (existing != null)
                    {
                        existing.ProductName = product.ProductName;
                        existing.Price = product.Price;
                        existing.Quantity = product.Quantity;
                        existing.Description = product.Description;
                        existing.Image = product.Image;
                        context.SaveChanges();
                    }
                }
            } 
            catch (Exception ex)
            {
                throw new Exception("Error updating product: " + ex.Message);
            }

        }
        public static void AddPro(Product product)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error adding product: " + ex.Message);
            }

        }
        public static  List<Product> GetallProduct()
        {
            List<Product> list = new List<Product>();
            try
            {
                using (var context = new BirdCage777Context())
                {
                    list = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;


        }
    }
}
