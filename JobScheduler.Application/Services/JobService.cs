using JobScheduler.Application.Interfaces;
using JobScheduler.Application.Dtos;

namespace JobScheduler.Application.Services
{
    public class JobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly ISqlRenderer _sqlRenderer;
        private readonly IJobExecutor _jobExecutor;

        public JobService(IJobRepository jobRepository, ISqlRenderer sqlRenderer, IJobExecutor jobExecutor)
        {
            _jobRepository = jobRepository;
            _sqlRenderer = sqlRenderer;
            _jobExecutor = jobExecutor;
        }

        public async Task<ExecuteJobResult> ExecuteJobAsync(Guid jobId)
        {
            var job = await _jobRepository.GetByIdAsync(jobId);
            if (job == null) throw new Exception("Job not found");

            var sql = await _sqlRenderer.RenderAsync(job);
            var result = await _jobExecutor.ExecuteAsync(job.DatabaseConnection, sql);

            return result;
        }
    }
}