
using Business.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersServices 
    {
        AplicationDbContext db;
        public UsersServices()
        {
             db = new AplicationDbContext();
        }
        public bool DeleteUser(int userId)
        {
            string commendText = $"UPDATE Users SET IsDeleted=1 WHERE UserId = {userId}";
            int result = db.ExecuteNoQuery(commendText);
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public DataTable GetUserById(int UserID)
        {
            string commendText = $"SELECT * FROM Users WHERE UserId = {UserID} and IsDeleted=0;";
            return db.ExecuteQuery(commendText);


        }

        public DataTable GetAllUsers()
        {
            string commendText = "SELECT * FROM Users WHERE  IsDeleted=0";
            return db.ExecuteQuery(commendText);

        }

        public bool InsertUser(string username, string password, string email, int age, string address, string role)
        {
            string commendText = $"INSERT INTO Users (Username, Password, Email, Age, Address, Role) VALUES ('{username}', '{password}', '{email}', {age}, '{address}', '{role}')";
            int result= db.ExecuteNoQuery(commendText);
            if (result == 0) {
                return false;
            }
            return true;

        }

        public bool UpdateUser(int userId, string username, string email, int age, string address, string role)
        {
            string commendText = $"UPDATE Users SET Email = {email}', Age = {age}, Address = '{address}' ,Username='{username}',Role='{role}'WHERE UserId = {userId} and IsDeleted = 0";
            int result = db.ExecuteNoQuery(commendText);
            if (result == 0)
            {
                return false;
            }
            return true;
        }



        public int Register(UserVM user)
        {

            return db.ExecuteNoQuery($"insert into Users (Username ,Address,Age ,Password , Email ,Role) values('{user.Name}','{user.Address}',{user.age},'{user.Password}','{user.Email}' ,'User')");

        }
        public DataTable Login(UserVM user)
        {
            return db.ExecuteQuery($"select * from Users where  Email='{user.Email}' and Password='{user.Password}'");
        }
    }
}
