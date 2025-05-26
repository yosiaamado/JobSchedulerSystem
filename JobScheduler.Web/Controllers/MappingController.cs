using JobScheduler.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;

namespace JobScheduler.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MappingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MappingController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("tables/{connectionId}")]
        public async Task<IActionResult> GetTables(Guid connectionId)
        {
            var conn = await _context.DatabaseConnections.FindAsync(connectionId);
            if (conn == null) return NotFound();

            using var db = SqlConnectionFactory.Create(conn);
            await db.OpenAsync();

            var tables = new List<string>();
            var cmd = db.CreateCommand();
            cmd.CommandText = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'dbo'";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                tables.Add(reader.GetString(0));
            }

            return Ok(tables);
        }
    }
}