using Microsoft.EntityFrameworkCore;
namespace ConsoleApp1;
public class SocialNetwork:DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post>Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public SocialNetwork()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SocialNetwork;Integrated Security=SSPI;");
    }
}