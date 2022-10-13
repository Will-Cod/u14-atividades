using Chapter.Models;
using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        //Rota que pega todosos dados do banco, os livros
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // Rota que busca um argumento em expecifico
        [HttpGet("{id}")]
        public IActionResult buscarPorId(int id)
        {
            try
            {
                Livro livro = _livroRepository.buscarPorId(id);

                if(livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Rota para cadastrar dados no banco
        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            try
            {
               _livroRepository.Cadastrar(livro);

                return StatusCode(201);

            }
            catch (Exception)
            {
                throw;
            }
        }
        //Rota para atualizar um item na tabela
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                _livroRepository.Atualizar(id, livro);
                return StatusCode(204);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")] //Rota para deletar um item
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
