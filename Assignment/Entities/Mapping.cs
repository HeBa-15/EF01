using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    [Table("Student",Schema ="dbo")]
    public class Mapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 6)]
        public string FName { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 6)]
        public string LName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }
        
        
        [Required]
        public int Age { get; set; }

        [Required]
        public int Dep_Id { get; set; }
    }


   
    public class Department : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Department>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department", schema: "dbo");

            builder.HasKey(D => D.ID);


            builder
                  .Property(D => D.ID)
                .UseIdentityColumn(10, 10);

            builder
                  .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");
        }
    }

    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int Bouns { get; set; }
        public int Dept_ID { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
    }

    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public string Grade { get; set; }
    }

    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }
}
