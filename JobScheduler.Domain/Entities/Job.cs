using JobScheduler.Domain.Enums;

namespace JobScheduler.Domain.Entities
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public JobType Type { get; set; }
        public Guid? TemplateId { get; set; }
        public string? RawSql { get; set; }

        public string CronSchedule { get; set; }
        public JobStatus Status { get; set; }

        public Guid DatabaseConnectionId { get; set; }
        public DatabaseConnection DatabaseConnection { get; set; }

        public List<JobMapping> Mappings { get; set; } = new();
        public List<JobExecutionLog> ExecutionLogs { get; set; } = new();
    }

}
