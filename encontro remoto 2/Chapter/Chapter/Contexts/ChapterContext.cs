using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }
        //Vamos utilizar o metodo  para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)//Se optionsBuilder não estiver configurado (!)
            {
                //cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-B600JJD\\SQLEXPRESS; initial catalog = Chapter; User id = sa; Password = Lolla9559@");
            }
        }

        //dbset representa as entidades que serão utilizadas nas operaçõesde litura, criação, atualização e delete
        public DbSet<Livro> livros { get; set; }

    }
}
