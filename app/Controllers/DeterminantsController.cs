using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace app.Controllers
{
    [Route("api/[controller]")]
    public class DeterminantsController : Controller
    {
        private static ILogger _logger;
        private static DeterminantsContext _context;

        public DeterminantsController(DeterminantsContext context, ILogger<DeterminantsController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDeterminants()
        {
            using (_context)
            {
                var determinants = _context.Determinants.ToList();

                _logger.LogInformation(JsonConvert.SerializeObject(determinants));

                return new JsonResult(determinants);
            }
        }

        [HttpPost]
        public IActionResult AddDeterminant([FromBody]Determinant determinant)
        {
            using (_context)
            {
                _context.Determinants.Add(determinant);
                _context.SaveChanges();

                return new OkResult();
            }
        }
    }
}