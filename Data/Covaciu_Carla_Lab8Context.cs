using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Covaciu_Carla_Lab8.Models;

namespace Covaciu_Carla_Lab8.Data
{
    public class Covaciu_Carla_Lab8Context : DbContext
    {
        public Covaciu_Carla_Lab8Context (DbContextOptions<Covaciu_Carla_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Covaciu_Carla_Lab8.Models.Book> Book { get; set; }

        public DbSet<Covaciu_Carla_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
