using lifehealth.Entities.DbSet;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lifeHealth.DataService.Data;

public class AppDbContext : IdentityDbContext
{
    public virtual DbSet<User> Users { get; set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

}
