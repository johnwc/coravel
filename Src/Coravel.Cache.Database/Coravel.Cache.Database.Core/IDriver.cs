using System.Data.Common;

namespace Coravel.Cache.Database.Core
{
    public interface IDriver
    {
        string TableName { get; }
        string DeleteByKeySQL { get; }
        string InsertOrUpdateCacheEntrySQL { get; }
        string GetCacheEntrySQL { get; }
        string CreateTablesSQL { get; }
        DbConnection CreateConnection(string connectionString);
    }
}