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
            return _context.livros.ToList(); // .Tolist() Lista todos os dados do banco
        }

        public Livro buscarPorId( int id)
        {
            return _context.livros.Find(id); // .Find() Busca um campo em expecifico
        }

        public void Cadastrar(Livro livro)
        {
            _context.livros.Add(livro); //.Add() cadastra um item no banco
            _context.SaveChanges(); // .SaveChanges() salva o item no banco
        }

        public void Atualizar (int id, Livro livro) //Atualiza itens no banco
        {
            Livro livroBuscado = _context.livros.Find(id);
            if(livroBuscado == null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }
            _context.livros.Update(livroBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id) //Deleta itens no banco
        {
            Livro livros = _context.livros.Find(id);
            _context.livros.Remove(livros);
            _context.SaveChanges();
        }
    }
}
