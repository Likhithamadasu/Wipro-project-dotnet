using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeInfo.Models;

namespace EmployeeInfo.Data
{
    public class EmployeeInfoContext : DbContext
    {
        public EmployeeInfoContext (DbContextOptions<EmployeeInfoContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeInfo.Models.Employee> Employee { get; set; } = default!;
    }
}
