using Microsoft.AspNetCore.Mvc;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;

        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }
    }
}
