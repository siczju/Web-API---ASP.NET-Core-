using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        // retorna coleção de Lanches, context.Lanches
        // retorna todos os registros da tabela Lanches do banco de dados
        // Include -> Vai retornar todos os lanches incluindo a categoria relacionada
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);


        // retorna coleção de Lanches preferidos, context.Lanches
        // retorna todos os registros da tabela Lanches do banco de dados
        // where -> Definindo uma condição pra receber os lanches, ou seja
        // IsLanchePreferido ser true
        public IEnumerable<Lanche> LanchesPreferidos => 
        _context.Lanches.Where(l => l.IsLanchePreferido).Include(c=>c.Categoria);


        // retorna um lanche pelo Id
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
        


    }
}
