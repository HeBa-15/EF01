using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{



    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

       
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInsts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            // Instructor
            modelBuilder.Entity<Instructor>()
                .ToTable("Instructor")
                .HasKey(i => i.ID);

            // Course
            modelBuilder.Entity<Course>()
                .ToTable("Course")
                .HasKey(c => c.ID);

            // Topic
            modelBuilder.Entity<Topic>()
                .ToTable("Topic")
                .HasKey(t => t.ID);

            // Stud_Course
            modelBuilder.Entity<Stud_Course>()
                .ToTable("Stud_Course")
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            // Course_Inst
            modelBuilder.Entity<Course_Inst>()
                .ToTable("Course_Inst")
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
        }




    }
}
