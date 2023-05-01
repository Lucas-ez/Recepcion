using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recepcion.Data
{
  public class RecepcionContext : IdentityDbContext
  {
    public RecepcionContext(DbContextOptions<RecepcionContext> options)
        : base(options)
    {
    }

    public DbSet<Recepcion.Models.Ingreso> Ingreso { get; set; } = default!;
  }
}
