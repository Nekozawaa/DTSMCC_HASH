using DTSMCC_Exam2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Employee> Employees { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }
    }
}
