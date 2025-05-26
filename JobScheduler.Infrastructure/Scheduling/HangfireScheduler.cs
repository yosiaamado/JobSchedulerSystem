using Hangfire;

namespace JobScheduler.Infrastructure.Scheduling
{
    public class HangfireScheduler
    {
        public void ScheduleRecurringJob(string jobId, string cronExpression, Action jobAction)
        {
            RecurringJob.AddOrUpdate(jobId, () => jobAction(), cronExpression);
        }
    }
}
