using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _contex;
        public ProducerController(AppDbContext context)
        {
            _contex = context;
                
        }
        public async Task<IActionResult> Index()
        {
            var producer = _contex.Producers.ToListAsync();
            return View(producer);
        }
    }
}
