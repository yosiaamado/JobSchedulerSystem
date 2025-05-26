using JobScheduler.Domain.Entities;
using JobScheduler.Application.Dtos;

namespace JobScheduler.Application.Interfaces
{
    public interface IJobExecutor
    {
        Task<ExecuteJobResult> ExecuteAsync(DatabaseConnection connection, string sql);
    }
}