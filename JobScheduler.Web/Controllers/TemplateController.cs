using JobScheduler.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobScheduler.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TemplateController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTemplates()
        {
            var templates = await _context.JobTemplates.ToListAsync();
            return Ok(templates);
        }
    }
}
