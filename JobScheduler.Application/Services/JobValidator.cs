namespace JobScheduler.Application.Services
{
    public class JobValidator
    {
        public bool IsSafeSql(string sql)
        {
            var lower = sql.ToLower();
            return !(lower.Contains("drop") || lower.Contains("alter") || lower.Contains("truncate") || lower.Contains(";"));
        }
    }
}