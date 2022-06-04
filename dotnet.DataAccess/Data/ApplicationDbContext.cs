using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess;

public class ApplicationDbContext:DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Category> Category { get; set; }
    public DbSet<CoverType> CoverTypes { get; set; }
}
