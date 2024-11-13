using Microsoft.EntityFrameworkCore;
using APIDemoB.Models;

namespace APIDemoB.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DAVEPC\\SQLEXPRESS; Database=APIDemoB; Integrated Security=True;Trust Server Certificate=True ");
        }
        public DbSet<APIDemoB.Models.Student> Student { get; set; } = default!;
    }
}
