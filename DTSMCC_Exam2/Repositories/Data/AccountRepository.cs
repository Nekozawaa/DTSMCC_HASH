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
        public ResponseLogin Regist(Regist regist)
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
    }
}
