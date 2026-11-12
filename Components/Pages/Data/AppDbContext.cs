
using Microsoft.EntityFrameworkCore;
using LostAndFound.Web.Models;

namespace LostAndFound.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<LostItem> Items => Set<LostItem>();
}
