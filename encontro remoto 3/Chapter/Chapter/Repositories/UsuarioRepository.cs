using Chapter.Interfaces;
using Chapter.Models;
using Chapter.Contexts;

namespace Chapter.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ChapterContext _contex;

        public UsuarioRepository(ChapterContext contex)
        {
            _contex = contex;
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _contex.Usuarios.Find(id);
            if(usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
                usuarioEncontrado.Tipo = usuario.Tipo;

                _contex.Usuarios.Update(usuarioEncontrado);
                _contex.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _contex.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario usuario)
        {
            _contex.Usuarios.Add(usuario);
            _contex.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioEncontrado = _contex.Usuarios.Find(id);
            _contex.Usuarios.Remove(usuarioEncontrado);
            _contex.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _contex.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return _contex.Usuarios.FirstOrDefault(x=> x.Email == email && x.Senha == senha);
        }
    }
}
