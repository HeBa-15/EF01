using EF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Configurations
{
    internal class EmployeeConfigurations : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees", schema: "dbo");

            //builder
            //.HasKey("SSN")
            //.HasKey(e=>e.SSN)
            //.HasKey(nameof(Employee.SSN))

                ;
            builder
                  .Property(e => e.SSN)
                .UseIdentityColumn(10, 10);

            builder
                  .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .HasDefaultValue("Ahmed")
                ;
        }
    }
}
