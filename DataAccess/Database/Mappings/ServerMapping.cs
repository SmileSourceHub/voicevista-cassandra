using System.Collections.Generic;
using voicevista_cassandra.DataAccess.Database.Models;
using voicevista_cassandra.Enpoints.Models;
using voicevista_cassandra.Services.Models;

namespace voicevista_cassandra.DataAccess.Database.Mappings
{
    public static class ServerMapping
    {
        public static Server ToDomain(this CreateRequestServer createRequestServer)
        {
            return new()
            {
                ServerId = System.Numerics.BigInteger.Zero,
                Name = createRequestServer.name,
            };
        }

        public static ServerDto ToDto(this Server server)
        {
            return new()
            {
                ServerId = server.ServerId,
                name = server.Name,
            };
        }
    }
}
