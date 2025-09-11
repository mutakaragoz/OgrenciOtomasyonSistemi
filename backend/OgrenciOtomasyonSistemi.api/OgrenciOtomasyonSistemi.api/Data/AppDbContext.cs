namespace OgrenciOtomasyonSistemi.api.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using OgrenciOtomasyonSistemi.api.Entities;

    public class AppDbContext
    {
        public class ApplicationDbContext : IdentityDbContext<AppUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Grade> Grades { get; set; }
            public DbSet<Attendance> Attendances { get; set; }
            public DbSet<Comment> Comments { get; set; }
        }

    }
}
