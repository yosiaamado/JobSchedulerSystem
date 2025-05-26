using JobScheduler.Application.Dtos;
using JobScheduler.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobScheduler.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly JobService _jobService;

        public JobController(JobService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost("execute/{id}")]
        public async Task<IActionResult> Execute(Guid id)
        {
            try
            {
                var result = await _jobService.ExecuteJobAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
