using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Proprietar> Proprietar { get; set; } = default!;
        public DbSet<Proiect.Models.Veterinar> Veterinar { get; set; } = default!;
        public DbSet<Proiect.Models.Animal> Animal { get; set; } = default!;
        public DbSet<Proiect.Models.Programare> Programare { get; set; } = default!;
        public DbSet<Proiect.Models.Tratament> Tratament { get; set; } = default!;
    }
}
