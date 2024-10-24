using BlogAppSample.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogAppSample.Data;
public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Post> Posts{ get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostsTags { get; set; } = default!;
}
