using Cassandra.Mapping;
using voicevista_cassandra.DataAccess;
using voicevista_cassandra.DataAccess.Database.Models;

namespace voicevista_cassandra.Configuration.Cassandra.Mappers
{
    public class ServerMapper
    {
        public static Map<ServerDto> GetMap()
        {
            return new Map<ServerDto>()
                .TableName(ServerRepository._tableName)
                .PartitionKey("ServerId", "ChannelId");
        }
    }
}
