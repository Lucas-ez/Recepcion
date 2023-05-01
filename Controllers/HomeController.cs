using Microsoft.AspNetCore.Mvc;
using Recepcion.Data;
using Recepcion.Models;
using System.Diagnostics;

namespace Recepcion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RecepcionContext _context;

        public HomeController(ILogger<HomeController> logger, RecepcionContext context)
        {
            _logger = logger;
            _context = context;
        }







        // GET: Ingresos
        public IActionResult Index()
        {
            return _context.Ingreso != null ?
                View(_context.Ingreso.ToList()) :
                Problem("Error en la base de datos");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}