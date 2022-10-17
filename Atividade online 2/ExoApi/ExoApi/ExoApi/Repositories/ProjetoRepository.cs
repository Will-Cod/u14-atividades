using ExoApi.Contexts;
using ExoApi.Models;
using ExoApi.Interfaces;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly dbExoApiContext _context;

        public ProjetoRepository(dbExoApiContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar() // Retorna uma lista da classe projetos
        {
            return _context.Projetos.ToList(); // retorna uma lista
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar (int id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);

            //Se o projetoBuscado for diferente != de nulo, alterar os campos abaixo
            if(projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Status = projeto.Status;
                projetoBuscado.Data_De_Inicio = projeto.Data_De_Inicio;
                projetoBuscado.Area = projeto.Area;
             }
            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = _context.Projetos.Find(id);
            _context.Projetos.Remove(projeto);
            _context.SaveChanges();
        }
    }
}
