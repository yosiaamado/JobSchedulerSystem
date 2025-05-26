using JobScheduler.Domain.Entities;

namespace JobScheduler.Application.Interfaces
{
    public interface ISqlRenderer
    {
        Task<string> RenderAsync(Job job);
    }
}