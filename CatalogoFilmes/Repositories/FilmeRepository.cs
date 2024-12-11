using CatalogoFilmes.Model;
using CatalogoFilmes.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CatalogoFilmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        public IEnumerable<Filme> ObterTodos()
        {
            List<Filme> filmes = new List<Filme>();

            filmes.Add(new Filme() { Id = 1, Nome = "Batman" });
            filmes.Add(new Filme() { Id = 2, Nome = "Predador" });
            filmes.Add(new Filme() { Id = 3, Nome = "A volta dos que nao foram" });
            filmes.Add(new Filme() { Id = 4, Nome = "Resident Evil" });
            return filmes;

        }
        public Filme ObterPorId(int id)
        {
            return ObterTodos().FirstOrDefault(f => f.Id == id);
        }

        void IFilmeRepository.Adicionar(Filme filme)
        {
            ObterTodos().add(filme);
        }

        //void IFilmeRepository.Atualizar(Filme filme)
        //{
        //    var filmeExistente = _filmes.FirstOrDefault(x => x.Id == filme.Id);
        //    if (filmeExistente != null)
        //    {
        //        filmeExistente = filme;
        //    }
        //}
        //void IFilmeRepository.Remover(int Id)
        //{
        //    var filmeParaRemover = _filmes.FirstOrDefault(x => x.Id == Id);
        //    if (filmeParaRemover != null)
        //    {
        //        _filmes.Remove(filmeParaRemover);
        //    }
        //}
    }
}

}
