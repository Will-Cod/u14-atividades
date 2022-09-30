using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context) 
        { 
            _context = context; 
        }
        public List<Livro> listar()
        {
            return _context.livros.ToList();
        }
    }
}
