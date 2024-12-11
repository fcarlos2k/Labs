using CatalogoFilmes.Model;
using CatalogoFilmes.Repositories;
namespace CatalogoFilmes.Repositories.Interfaces
{
    public interface IFilmeRepository
    {
        IEnumerable<Filme> ObterTodos();
        Filme ObterPorId(int Id);
        void Adicionar(Filme filme);
        //void Adicionar(Filme filme);
        //void Atualizar(Filme filme);
        //void Remover(int Id);
    }
}
