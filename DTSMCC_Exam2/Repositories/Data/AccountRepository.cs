using DTSMCC_Exam2.Context;
using DTSMCC_Exam2.Models;
using DTSMCC_Exam2.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Repositories.Data
{
    public class AccountRepository
    {
        MyContext myContext;
        public AccountRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public class Hashing
        {
            private static string GetRandomSalt()
            {
                return BCrypt.Net.BCrypt.GenerateSalt(12);
            }
            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
            }
            public static bool ValidatePassword(string password, string correctHash)
            {
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
        }

        //LOGIN
        public ResponseLogin Login(Login login)
        {
            var data = myContext.UserRoles
                .Include(x => x.Role)
                .Include(x => x.user)
                .Include(x => x.user.Employee)
                .FirstOrDefault(x =>
                    x.user.Employee.email.Equals(login.Email) &&
                    x.user.password.Equals(login.Password));
            if (data != null)
            {
                ResponseLogin responseLogin = new ResponseLogin()
                {
                    id = data.user.id,
                    fullName = data.user.Employee.fullName,
                    email = data.user.Employee.email,
                    Role = data.Role.name
                };
                return responseLogin;
            }
            return null;
        }

        //REGIST
        public ResponseRegist Regist(Regist regist)
        {
            regist.Password =  Hashing.HashPassword(regist.Password);
            myContext.UserRoles.Add(regist);
            var result = myContext.SaveChanges();
            return result;
        }

        //CHANGE PASSWORD
        public int Change(Login login)
        {
            
        }
    }
}
