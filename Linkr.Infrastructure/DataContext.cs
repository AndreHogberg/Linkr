using Linkr.Domain;
using Microsoft.EntityFrameworkCore;

namespace Linkr.Infrastructure;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> opt) : base(opt)
    {
    }

    public DbSet<Link> Links { get; set; }
    public DbSet<LinkGroup> LinkGroups { get; set; }
    public DbSet<SingleRedirect> SingleRedirects { get; set; }
}