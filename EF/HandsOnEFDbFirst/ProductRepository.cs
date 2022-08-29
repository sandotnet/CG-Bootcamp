using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFDbFirst.Entities;
namespace HandsOnEFDbFirst
{
    internal class ProductRepository
    {
        private readonly EMIDSDBContext db;
        public ProductRepository()
        {
            this.db = new EMIDSDBContext();
        }
        public void GetAllProducts() //to get all products
        {
            List<Product> products = db.Products.ToList();
            //products = (from p in db.Products select p).ToList();
         foreach(var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Pid, item.Pname, item.Price, item.Stock);
            }
        }
        public void GetProductById(int id) //GetProductById
        {
            Product item=db.Products.Find(id); //Find() use only to fetch record using primary key column
            //product = db.Products.Single(p => p.Pid == id); //use Single for non primary key columns
            if (item != null)
                Console.WriteLine("{0} {1} {2} {3}", item.Pid, item.Pname, item.Price, item.Stock);
            else
                Console.WriteLine("Invalid Id");
        }
        public void AddProduct(Product product) //Add Product
        {
            db.Products.Add(product);
            db.SaveChanges(); //it saves record in table
        }
        public void EditProduct(Product product) //Edit Product
        {
            db.Products.Update(product);
            db.SaveChanges(); //it saves record in table
        }
        public void DeleteProduct(int id) //Delete Product
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }
        public static void Main()
        {
            ProductRepository repository = new ProductRepository();
            // repository.GetAllProducts();
            // Console.WriteLine();
            //Product product = new Product() { Pid = 3, Pname = "AAA", Price = 25, Stock = 70 };
            //repository.AddProduct(product);
            //repository.EditProduct(product);
            repository.DeleteProduct(1);
            repository.GetAllProducts();
            //repository.GetProductById(1);
        }
    }
}
