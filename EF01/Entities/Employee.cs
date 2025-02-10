using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{

    // EF Core 4 Ways for Mapping (Table , Function ,View)
    // 1. By Convention (Default)
    // 2. By Data Annotation
    // 3. By Fluent Api
    // 4. By Configuration



    // Poco Class => Plained Old CLR Object Class

    #region By Convention (Default)
    //internal class Employee
    //{
    //    public int Id { get; set; }// public Numeric Property 'Id' || 'EmployeeId' => // PK Identity (1,1)
    //    public string? Name { get; set; } // Reference Type : string => nvarchar(Max) Not Req
    //    public int? Age { get; set; } //Value Type : int => Nullable<int>

    //    public decimal Salary { get; set; } // Float


    //} 

    #endregion



    #region  By Data Annotation

    //[Table("Employees",Schema ="dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int EmpId { get; set; }// 'EmpId' =>  PK Identity (1,1)

    //    [Required]
    //    [MaxLength(50)]
    //    [Column(TypeName = "varchar")]
    //    [StringLength(50, MinimumLength = 6)]
    //    public string? Name { get; set; } // varchar(50) Req not null


    //    [Required]
    //    [Range(18, 60)]
    //    public int? Age { get; set; } // req range 18,60
    //    [Column(TypeName = "money")]
    //    public decimal? Salary { get; set; } // 


    //    [EmailAddress]
    //    public string? Email { get; set; }

    //    [Required]
    //    [Phone]
    //    public string? Phone { get; set; }
    //}
    #endregion



    #region By Fluent & By Config
    class Employee
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
    #endregion









}
