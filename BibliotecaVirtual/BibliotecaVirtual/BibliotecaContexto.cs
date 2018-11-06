using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    class BibliotecaContexto : DbContext, IDisposable
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo>Emprestimos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BibliotecaVirtual;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//executado na criaçao do modelo
        {

            modelBuilder
                .Entity<Livro>()
                .HasKey(pp => new { pp.Id});

            modelBuilder
                .Entity<Usuario>()
                .HasKey(pp => new { pp.Id});

            base.OnModelCreating(modelBuilder);

            //////////////////////////////////////
        }
    }
}

