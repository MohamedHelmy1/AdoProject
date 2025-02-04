using Business.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product_Services
    {
        AplicationDbContext db;
        public Product_Services()
        {
            db = new AplicationDbContext();
        }

        public DataTable getProducts()
        {
            return db.ExecuteQuery("SELECT P.*, C.CategoryName FROM Products P JOIN Categories C ON P.CategoryId = C.CategoryId");
        }
        public int DeleteProduct(int Id)
        {
            return db.ExecuteNoQuery($"UPDATE Products SET IsDeleted = 1 WHERE ProductId = {Id} ");
        }
        public int AddProduct(ProductVM productVM)
        {
            return db.ExecuteNoQuery($"insert into Products (ProductName, Price, CategoryId) values('{productVM.Name}',{productVM.Price},'{productVM.Ctg_Id}')");
        }
        public int UpdateProduct(ProductVM productVM)
        {
            return db.ExecuteNoQuery($"update Products set ProductName ='{productVM.Name}' ,Price='{productVM.Price}' , CategoryId={productVM.Ctg_Id} WHERE ProductId = {productVM.ID} ;");
        }

        public DataTable getProductCategort(int CatogeryName)
        {
            return db.ExecuteQuery($"SELECT * FROM Products WHERE CategoryId = {CatogeryName};");
        }
       
        public DataTable getOneProduct(int Prod_Id)
        {
            return db.ExecuteQuery($"SELECT P.*, C.CategoryName FROM Products P JOIN Categories C ON P.CategoryId = C.CategoryId where ProductId={Prod_Id}");
        }
       
    }
}
