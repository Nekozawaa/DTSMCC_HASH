using DTSMCC_Exam2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Repositories.Interface
{
    interface IEmployee
    {
        List<Employee> Get();
        Employee Get(int id);
        int Post(Employee employee);
        int Put(Employee employee);
        int Delete(int id);
    }
}
