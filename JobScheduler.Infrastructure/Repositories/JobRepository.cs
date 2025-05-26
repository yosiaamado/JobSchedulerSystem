using JobScheduler.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using JobScheduler.Infrastructure.Database;

namespace JobScheduler.Infrastructure.Repositories
{
    public class JobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Job?> GetByIdAsync(Guid id) =>
            _context.Jobs.Include(j => j.Mappings).FirstOrDefaultAsync(j => j.Id == id);
    }
}