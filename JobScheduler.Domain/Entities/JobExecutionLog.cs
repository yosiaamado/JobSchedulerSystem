namespace JobScheduler.Domain.Entities
{
    public class JobExecutionLog
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public DateTime ExecutedAt { get; set; }
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public int? RowsAffected { get; set; }
        public int DurationMs { get; set; }
    }

}
