using PruebaMvcCore.Data;
using PruebaMvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMvcCore.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;

        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }

        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }

        public Coche FindCoche(int id)
        {
            return this.context.Coches.SingleOrDefault
            (x => x.IdCoche == id);
        }

    }
}
