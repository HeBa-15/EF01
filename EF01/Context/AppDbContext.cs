using EF01.Entities;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees", schema: "dbo");


            modelBuilder.Entity<Employee>()
                //.HasKey("SSN")
                //.HasKey(e=>e.SSN)
                //.HasKey(nameof(Employee.SSN))
                
                ;
            modelBuilder.Entity<Employee>()
                .Property(e => e.SSN)
                .UseIdentityColumn(10,10);
           
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .HasDefaultValue("Ahmed")
                ;
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
