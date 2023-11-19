using System.Xml.Linq;
using voicevista_cassandra.DataAccess.Database.Interfaces;
using voicevista_cassandra.DataAccess.Database.Mappings;
using voicevista_cassandra.Enpoints.Models;
using voicevista_cassandra.Services.Interfaces;

namespace voicevista_cassandra.Services
{
    public class ServerService : IServerService
    {
        private readonly IServerRepository _serverRepository;

        public ServerService(IServerRepository serverRepository)
        {
            _serverRepository = serverRepository;
        }

        public async Task ServerCreate(CreateRequestServer createRequestServer)
        {
            var server = createRequestServer.ToDomain();
            await _serverRepository.Create(server.ToDto());
        }
    }
}
