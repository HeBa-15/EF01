using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Context
{
    internal class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=.;database =EFCoreDbGroup01;Trusted_Connection =true;";
            
            optionsBuilder.UseSqlServer(connectionString);
        
        }
    }
}
