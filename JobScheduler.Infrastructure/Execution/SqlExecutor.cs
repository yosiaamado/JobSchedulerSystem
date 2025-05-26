using Dapper;
using System.Data.Common;

namespace JobScheduler.Infrastructure.Execution
{
    public class SqlExecutor
    {
        public async Task<int> ExecuteAsync(DbConnection connection, string sql)
        {
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();
            try
            {
                var affected = await connection.ExecuteAsync(sql, transaction: transaction);
                transaction.Commit();
                return affected;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }
    }
}