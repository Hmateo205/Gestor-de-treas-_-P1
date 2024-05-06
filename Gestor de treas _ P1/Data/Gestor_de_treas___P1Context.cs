using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gestor_de_treas___P1.Models;

namespace Gestor_de_treas___P1.Data
{
    public class Gestor_de_treas___P1Context : DbContext
    {
        public Gestor_de_treas___P1Context (DbContextOptions<Gestor_de_treas___P1Context> options)
            : base(options)
        {
        }

        public DbSet<Gestor_de_treas___P1.Models.Tarea> Tarea { get; set; } = default!;
    }
}
