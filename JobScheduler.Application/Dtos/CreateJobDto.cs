namespace JobScheduler.Application.Dtos
{
    public class CreateJobDto
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = "template";
        public Guid? TemplateId { get; set; }
        public string? RawSql { get; set; }
        public string Cron { get; set; } = string.Empty;
        public Guid DatabaseConnectionId { get; set; }
        public Dictionary<string, string> Mappings { get; set; } = new();
    }
}