using CatalogoFilmes.Model;
using CatalogoFilmes.Policy;
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
            if (!FilmeVazio.ValidarFilme(filme))
            {
                return NotFound("Filme nao encontrado");
            }
            return Ok(filme);
        }


        [HttpGet("ObterPorNome")]
        public ActionResult<Filme> ObterPorNome([FromQuery] string nome)
        {
            var filme = _repository.ObterPorNome(nome);
            if (filme == null)
            {
                return NotFound("Filme nao encontrado");
            }
            return Ok(filme);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Filme filme)
        {
            _repository.Adicionar(filme);
            //return Ok();
            return Ok("Codigo do filme INCLUIDO: " + filme.Id);

        }


        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Filme filme)
        {
            var filmeAtualizar = _repository.ObterPorId(id);
            if (!FilmeVazio.ValidarFilme(filmeAtualizar))
            {
                return BadRequest("Filme nao encontrado");
            }
            else
            {
                _repository.Atualizar(filme);
                return Ok("Codigo do filme ATUALIZADO: " + filme.Id);
            }
        }



        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var filme = _repository.ObterPorId(id);
            if (filme is null)
            {
                return BadRequest("Filme nao encontrado");
            }
            else
            {
                _repository.Remover(id);
                return Ok("Codigo do filme DELETADO: " + id);
            }
        }
    }
}