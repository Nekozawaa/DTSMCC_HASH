using DTSMCC_Exam2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Repositories.Interface
{
    interface ILogin
    {
        List<Login> Get();
        Login Get(int id);
        int Post(Login login);
    }
}
