using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        // retorna coleção de Categorias, context.Categorias
        // retorna todos os registros da tabela Categorias do banco de dados
        public IEnumerable<Categoria> Categorias => _context.Categorias; 
    }
}
