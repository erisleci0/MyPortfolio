using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.ViewModels;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PortfolioDbContext db = new PortfolioDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var portfolioDetailsViewModel = new PortfolioDetailsViewModel()
            {
                Skills = db.Skills.ToList(),
                Socials = db.Socials.ToList(),
            };

            return View(portfolioDetailsViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}