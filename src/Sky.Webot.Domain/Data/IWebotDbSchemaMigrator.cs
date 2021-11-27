using System.Threading.Tasks;

namespace Sky.Webot.Data
{
    public interface IWebotDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
