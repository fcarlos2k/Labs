using CatalogoFilmes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        //private readonly List<FilmesModel> filmesModels = new List<FilmesModel>();
        /*

        
        public void filmeslista()
        {
            List<FilmesModel> filmesModels = new List<FilmesModel>();

            filmesModels.Add(new FilmesModel() { Id = 1, Nome = "Bataman" });

        }
        
        */


        [HttpGet]
        public IEnumerable<FilmesModel> BuscarTodosFilmes()
        {
            List<FilmesModel> filmesModels = new List<FilmesModel>();

            filmesModels.Add(new FilmesModel()
            {
                Id = 1,
                Nome = "Batman"
            });

            //var filmes = filmesModels();
            //string filme = "Todos os filmes";
            return filmesModels;
        }

        //[HttpPost]

        //[HttpPut]

        //[HttpDelete]
    }
}