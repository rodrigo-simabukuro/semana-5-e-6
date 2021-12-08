using Microsoft.EntityFrameworkCore;
using Proj_semana5e6.Mappings;
using Proj_semana5e6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_semana5e6.Context
{
    public class DataContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=Proj_Semana5e6;Integrated Security=true");
        //}
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaminhaoMap());
        }
        public DbSet<Caminhao> caminhoes { get; set; }

    }
}
