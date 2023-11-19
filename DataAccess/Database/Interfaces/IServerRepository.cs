using voicevista_cassandra.DataAccess.Database.Models;

namespace voicevista_cassandra.DataAccess.Database.Interfaces
{
    public interface IServerRepository
    {
        Task Create(ServerDto server);
    }
}
