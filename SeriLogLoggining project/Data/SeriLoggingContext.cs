using Microsoft.EntityFrameworkCore;
using SeriLogLoggining_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogLoggining_project.Data
{
    public class SeriLoggingContext : DbContext
    {
        public SeriLoggingContext(DbContextOptions<SeriLoggingContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}