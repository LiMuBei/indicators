using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace app.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private static ILogger _logger;
        private static SqliteContext _context;

        public CountriesController(SqliteContext context, ILogger<CountriesController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            using (_context)
            {
                var countries = _context.Countries.ToList();

                _logger.LogInformation(JsonConvert.SerializeObject(countries));

                return new JsonResult(countries);
            }
        }
    }
}