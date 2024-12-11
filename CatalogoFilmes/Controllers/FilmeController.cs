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
            //GetFilmesId (x => x.Id == id);
            if (filme is null)
            {
                return NotFound("Filme nao encontrado");
            }
            return Ok(filme);
        }


        [HttpPost]

        public ActionResult<Filme> Post(Filme filme)
        {
            _repository.ad filmes.Add(new Filme() { Id = 1, Nome = "Batman" });
            return Ok();
        }

        //[HttpPut]

        //[HttpDelete]
    }

}