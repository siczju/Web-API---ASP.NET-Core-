using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository) {
            _lancheRepository = lancheRepository;
        }

        // listar os lanches
        // Como eu n informei o nome da view ele vai procurar uma
        // view com o nome do método (List)
        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches; // retorna lista de todos lanches
            return View(lanches);
        }
    }
}
