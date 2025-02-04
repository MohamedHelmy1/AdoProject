using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FavouriteServices
    {
        AplicationDbContext db;
        public FavouriteServices()
        {
            db = new AplicationDbContext();

        }

        public int AddProductFavourite(int User_Id, int Prod_Id)
        {
            return db.ExecuteNoQuery($"INSERT INTO Favorites (UserId, ProductId) VALUES ({User_Id},{Prod_Id})");
        }
        public int DeleteProductFavourite(int User_Id, int Prod_Id)
        {
            return db.ExecuteNoQuery($"DELETE FROM Favorites WHERE UserId = {User_Id} AND ProductId {Prod_Id}");
        }
        public DataTable getFavProduct(int Useer_Id)
        {
            return db.ExecuteQuery($"SELECT P.ProductId, P.ProductName, P.Price, C.CategoryName  FROM Favorites F JOIN Products P ON F.ProductId = P.ProductId JOIN Categories C ON P.CategoryId = C.CategoryId WHERE F.UserId = {Useer_Id}");
        }

    }
}
