using Microsoft.EntityFrameworkCore;
using PruebaMvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMvcCore.Data
{
    public class CochesContext: DbContext
    {
        public CochesContext
        (DbContextOptions<CochesContext> options) : base(options) { }

        public DbSet<Coche> Coches { get; set; }
    }
}
