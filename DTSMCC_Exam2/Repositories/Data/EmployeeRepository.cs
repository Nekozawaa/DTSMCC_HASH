using DTSMCC_Exam2.Context;
using DTSMCC_Exam2.Models;
using DTSMCC_Exam2.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Repositories.Data
{
    public class EmployeeRepository : IEmployee
    {
        MyContext myContext;
        public EmployeeRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var data = Get(id);
            myContext.Employees.Remove(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Employee> Get()
        {
            var data = myContext.Employees.ToList();
            return data;
        }

        public Employee Get(int id)
        {
            var data = myContext.Employees.Find(id);
            return data;
        }

        public int Post(Employee employee)
        {
            myContext.Employees.Add(employee);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(Employee employee)
        {
            var data = Get(employee.id);
            data.fullName = employee.fullName;
            data.email = employee.email;
            myContext.Employees.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
