using CatalogoFilmes.Model;
using CatalogoFilmes.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {

        private readonly IFilmeRepository _repository;

        public FilmeController(IFilmeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Filme>> ListarTodosFilmes()
        {
            IEnumerable<Filme> filmes = _repository.ObterTodos();

            return Ok(filmes);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Filme> Get(int id)
        {
            var filme = _repository.ObterPorId(id);
            if (filme is null)
            {
                return NotFound("Filme nao encontrado");
            }
            return Ok(filme);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Filme filme)
        {
            _repository.Adicionar(filme);
            return Ok();
        }


        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Filme filme)
        {
            _repository.Atualizar(filme);
            return NoContent();
        }



        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            if 
            _repository.Remover(id);
            return NoContent();
        }
    }
}