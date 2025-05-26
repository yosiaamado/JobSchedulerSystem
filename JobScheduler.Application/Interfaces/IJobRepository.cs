using JobScheduler.Domain.Entities;

namespace JobScheduler.Application.Interfaces
{
    public interface IJobRepository
    {
        Task<Job?> GetByIdAsync(Guid id);
    }
}