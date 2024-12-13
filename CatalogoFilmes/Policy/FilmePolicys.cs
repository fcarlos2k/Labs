using CatalogoFilmes.Model;

namespace CatalogoFilmes.Policy

{
    public static class FilmeVazio
    {
        public static bool ValidarFilme(Filme filme)
        {
            return filme != null;
        }
    }
}