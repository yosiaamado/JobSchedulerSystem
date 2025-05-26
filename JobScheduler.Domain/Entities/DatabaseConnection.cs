using JobScheduler.Domain.Enums;

namespace JobScheduler.Domain.Entities
{
    public class DatabaseConnection
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DBType DbType { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string PasswordEncrypted { get; set; }

        public List<Job> Jobs { get; set; }
    }

}
