
using Microsoft.AspNetCore.Mvc;
using SpaceTourAPI.Data;
using SpaceTourAPI.Models;

namespace SpaceTourAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToursController : ControllerBase
    {
        private readonly SpaceTourContext _context;

        public ToursController(SpaceTourContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tour>> GetTours()
        {
            if (!_context.Tours.Any())
            {
                _context.Tours.Add(new Tour { Name = "Moon Expedition", Description = "Explore the Moon!", Capacity = 5, Price = 4999.99M, StartDate = DateTime.Now.AddMonths(1) });
                _context.SaveChanges();
            }
            return _context.Tours.ToList();
        }
    }
}
