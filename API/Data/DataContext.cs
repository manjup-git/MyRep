using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<AppUser> Users { get; set;}
}
/*
Note: to view the database open command pallate and select sqllite: open database
*/