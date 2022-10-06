
// Classe onde fica o endereço do banco, onde vai ser buscado os dados

using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts

{
    public class dbExoApiContext:DbContext
    {
        public dbExoApiContext()
        {
        }
        public dbExoApiContext(DbContextOptions<dbExoApiContext> options): base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-B600JJD\\SQLEXPRESS; initial catalog = dbExoApi; User Id = sa; Password = Lolla9559@");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
