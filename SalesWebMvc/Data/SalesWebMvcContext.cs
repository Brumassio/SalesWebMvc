using Microsoft.EntityFrameworkCore;

public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
{
    public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
    public DbSet<SalesWebMvc.Models.Seller> Seller { get; set; } = default!;
    public DbSet<SalesWebMvc.Models.SalesRecord> SalesRecord { get; set; } = default!;

}
