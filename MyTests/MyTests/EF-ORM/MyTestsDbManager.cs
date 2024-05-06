using MyTests.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace MyTests.EF_ORM
{
    public class MyTestsDbManager : DbContext
    {
        
        public MyTestsDbManager()
            : base("name=MyTestsDbManager")
        {
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
    }
}