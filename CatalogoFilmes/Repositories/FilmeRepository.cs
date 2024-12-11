using CatalogoFilmes.Model;
using CatalogoFilmes.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CatalogoFilmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private readonly List<Filme> _filmes;

        public FilmeRepository()
        {
            _filmes = new List<Filme>
        {
            new Filme { Id = 1, Nome = "Batman"},
            new Filme { Id = 2, Nome = "Predador"},
            new Filme { Id = 3, Nome = "A volta dos que nao foram"},
            new Filme { Id = 4, Nome = "Resident Evil"}
        };
        }

        public IEnumerable<Filme> ObterTodos()
        {
            return _filmes;
        }


        public Filme ObterPorId(int id)
        {
            return _filmes.FirstOrDefault(x => x.Id == id);
        }


        void IFilmeRepository.Adicionar(Filme filme)
        {
            _filmes.Add(filme);
        }

        void IFilmeRepository.Atualizar(Filme filme)
        {
            var filmeParaAtualizar = _filmes.FirstOrDefault(x => x.Id == filme.Id);
            if (filmeParaAtualizar != null)
            {
                filmeParaAtualizar.Id = filme.Id;
                filmeParaAtualizar.Nome = filme.Nome;
            }
        }

        void IFilmeRepository.Remover(int Id)
        {
            var filmeParaRemover = _filmes.FirstOrDefault(x => x.Id == Id);
            if (filmeParaRemover != null)
            {
                _filmes.Remove(filmeParaRemover);
            }
        }
    }
}