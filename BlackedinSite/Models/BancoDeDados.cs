using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackedinSite.Models
{
    
    public class BancoDeDados : DbContext
    {
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=BlackedinSite;integrated security=True");
        }
    }
}
