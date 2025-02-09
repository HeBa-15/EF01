using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{

    // EF Core 4 Ways for Mapping (Table , Function ,View)
    // 1. By Convention (Default)
    // 2. By Data Annotation




    // Poco Class => Plained Old CLR Object Class

    #region By Convention (Default)
    internal class Employee
    {
        public int Id { get; set; }// public Numeric Property 'Id' || 'EmployeeId' => // PK Identity (1,1)
        public string? Name { get; set; } // Reference Type : string => nvarchar(Max) Not Req
        public int? Age { get; set; } //Value Type : int => Nullable<int>
        
        public decimal Salary { get; set; } // Float

    
    } 

    #endregion
}
