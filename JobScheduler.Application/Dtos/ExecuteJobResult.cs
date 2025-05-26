namespace JobScheduler.Application.Dtos
{
    public class ExecuteJobResult
    {
        public bool Success { get; set; }
        public int RowsAffected { get; set; }
        public string? ErrorMessage { get; set; }
    }
}