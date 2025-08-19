using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Submission> Submissions { get; set; }
}