using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recepcion.Models;

namespace Recepcion.Data
{
    public class RecepcionContext : DbContext
    {
        public RecepcionContext (DbContextOptions<RecepcionContext> options)
            : base(options)
        {
        }

        public DbSet<Recepcion.Models.Ingreso> Ingreso { get; set; } = default!;
    }
}
