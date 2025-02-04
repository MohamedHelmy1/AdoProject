
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
    public class CatogeryServices
    {
        AplicationDbContext db;
        public CatogeryServices() {
            db = new AplicationDbContext();
        }
       
       
        public DataTable getCategory()
        {
            return db.ExecuteQuery("SELECT * FROM Categories WHERE  IsDeleted=0");
        }
        public int DeleteCategory(int Id)
        {
            return db.ExecuteNoQuery($"UPDATE Categories SET IsDeleted = 1 WHERE CategoryId ={Id}");
        }
        public int AddCategory(CategoryVM categoryVM)
        {
            return db.ExecuteNoQuery($"INSERT INTO Categories (CategoryName) VALUES ('{categoryVM.Name}')");
        }
        public int UpdateCategory(CategoryVM categoryVM)
        {
            return db.ExecuteNoQuery($"UPDATE Categories SET CategoryName = '{categoryVM.Name}' WHERE CategoryId = {categoryVM.ID} and IsDeleted = 0");
        }


    }
}
