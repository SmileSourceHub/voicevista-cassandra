using voicevista_cassandra.Enpoints.Models;

namespace voicevista_cassandra.Services.Interfaces
{
    public interface IServerService
    {
        Task ServerCreate(CreateRequestServer createRequestServer);
    }
}
