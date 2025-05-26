using System.Data.Common;
using Microsoft.Data.SqlClient;
using JobScheduler.Domain.Entities;

namespace JobScheduler.Infrastructure.Database
{
    public static class SqlConnectionFactory
    {
        public static DbConnection Create(DatabaseConnection config)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = $"{config.Host},{config.Port}",
                InitialCatalog = config.DatabaseName,
                UserID = config.Username,
                Password = Decrypt(config.PasswordEncrypted),
                TrustServerCertificate = true,
                Encrypt = false
            };
            return new SqlConnection(builder.ConnectionString);
        }

        private static string Decrypt(string encrypted) => encrypted; // TODO: implement secure decryption
    }
}
