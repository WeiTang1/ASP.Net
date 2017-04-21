namespace CodeMigrationTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentDataContext : DbContext
    {
        // Your context has been configured to use a 'StudentDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeMigrationTest.Models.StudentDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentDataContext' 
        // connection string in the application configuration file.
        public StudentDataContext()
            : base("name=StudentDataContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // migration new attributes
        public int Age { get; set; }
        public String Major { get; set; }
    }

}