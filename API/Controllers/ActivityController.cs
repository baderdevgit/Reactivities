
using Domain.obj;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {

        private readonly DataContext _context;
        public ActivityController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) {
            var activity = await _context.Activities.FindAsync(id);
    
            if (activity == null)
            {
                return NotFound();  // Return a 404 if the activity is null
            }
            return Ok(activity);
        }
    }
}