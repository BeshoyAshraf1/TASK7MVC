using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace task3.Models
{
    public class ApplicationDbContext : DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public DbSet<Instractor> Instractors { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<trainee> trainees { get; set; }
        public DbSet<Courseresult> Courseresults { get; set; }
        public DbSet<Depratment> Depratments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Departments
            modelBuilder.Entity<Depratment>().HasData(
                new Depratment { id = 1, name = "Computer Science", managername = "John Doe" },
                new Depratment { id = 2, name = "Mathematics", managername = "Jane Smith" },
                new Depratment { id = 3, name = "Physics", managername = "Albert Einstein" },
                new Depratment { id = 4, name = "Chemistry", managername = "Marie Curie" },
                new Depratment { id = 5, name = "Biology", managername = "Charles Darwin" }
            );

            // Instructors
            modelBuilder.Entity<Instractor>().HasData(
                new Instractor { Id = 1, Name = "Alice Johnson", image = "alice.jpg", Salary = 50000, address = "123 Main St", DepratmentId = 1, CourseId = 1 },
                new Instractor { Id = 2, Name = "Bob Lee", image = "bob.jpg", Salary = 55000, address = "456 Elm St", DepratmentId = 2, CourseId = 2 },
                new Instractor { Id = 3, Name = "Charlie Brown", image = "charlie.jpg", Salary = 60000, address = "789 Pine St", DepratmentId = 3, CourseId = 3 },
                new Instractor { Id = 4, Name = "Diana Prince", image = "diana.jpg", Salary = 62000, address = "101 Oak St", DepratmentId = 4, CourseId = 4 },
                new Instractor { Id = 5, Name = "Eve Adams", image = "eve.jpg", Salary = 65000, address = "202 Maple St", DepratmentId = 5, CourseId = 5 }
            );

            // Trainees
            modelBuilder.Entity<trainee>().HasData(
                new trainee { Id = 1, Name = "Tom Brown", image = "tom.jpg", Grade = 85.5, address = "123 Maple St" },
                new trainee { Id = 2, Name = "Sarah Green", image = "sarah.jpg", Grade = 90.0, address = "456 Oak St" },
                new trainee { Id = 3, Name = "James Blue", image = "james.jpg", Grade = 88.0, address = "789 Pine St" },
                new trainee { Id = 4, Name = "Emma White", image = "emma.jpg", Grade = 92.5, address = "101 Elm St" },
                new trainee { Id = 5, Name = "Liam Black", image = "liam.jpg", Grade = 87.0, address = "202 Main St" }
            );

            // Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Introduction to Programming", Degree = 100, MinDegree = 60 },
                new Course { Id = 2, Name = "Advanced Mathematics", Degree = 100, MinDegree = 70 },
                new Course { Id = 3, Name = "Quantum Physics", Degree = 100, MinDegree = 75 },
                new Course { Id = 4, Name = "Organic Chemistry", Degree = 100, MinDegree = 65 },
                new Course { Id = 5, Name = "Genetics", Degree = 100, MinDegree = 80 }
            );

            // CourseResults
            modelBuilder.Entity<Courseresult>().HasData(
                new Courseresult { Id = 1, Degree = 95, CourseId = 1, traineeId = 1 },
                new Courseresult { Id = 2, Degree = 88, CourseId = 2, traineeId = 2 },
                new Courseresult { Id = 3, Degree = 92, CourseId = 3, traineeId = 3 },
                new Courseresult { Id = 4, Degree = 85, CourseId = 4, traineeId = 4 },
                new Courseresult { Id = 5, Degree = 90, CourseId = 5, traineeId = 5 }
            );
        }

    }
}
