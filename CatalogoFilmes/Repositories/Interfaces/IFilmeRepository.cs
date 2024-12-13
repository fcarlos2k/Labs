using CatalogoFilmes.Model;
using CatalogoFilmes.Repositories;
namespace CatalogoFilmes.Repositories.Interfaces
{
    public interface IFilmeRepository
    {
        IEnumerable<Filme> ObterTodos();
        Filme? ObterPorId(int Id);
        IEnumerable<Filme> ObterPorNome(string Nome);
        void Adicionar(Filme filme);
        void Atualizar(Filme filme);
        void Remover(int Id);

    }
}
