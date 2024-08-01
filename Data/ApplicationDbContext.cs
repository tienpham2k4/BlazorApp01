using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp01.Models;

namespace BlazorApp01.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorApp01.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<BlazorApp01.Models.Departments> Departments { get; set; } = default!;
        public DbSet<BlazorApp01.Models.Majors> Majors { get; set; } = default!;
        public DbSet<BlazorApp01.Models.Subjects> Subjects { get; set; } = default!;
        public DbSet<BlazorApp01.Models.Courses> Courses { get; set; } = default!;
        public DbSet<BlazorApp01.Data.ApplicationUser> ApplicationUsers { get; set; } = default!;
    }
}
