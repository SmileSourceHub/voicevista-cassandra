using Cassandra;
using Cassandra.Mapping;
using IdGen;
using voicevista_cassandra.DataAccess.Database.Interfaces;
using voicevista_cassandra.DataAccess.Database.Models;

namespace voicevista_cassandra.DataAccess
{
    public class ServerRepository : IServerRepository
    {
        private readonly Cassandra.ISession _client;
        public readonly static string _tableName = "servers";
        private readonly string _keySpaceName;

        public ServerRepository(IConfiguration configuration)
        {
            _keySpaceName = configuration["CassandraConfig:KeySpaceName"];
            var cluster = Cluster.Builder()
                     .AddContactPoints(configuration["CassandraConfig:HostName"])
                     .Build();

            // Connect to the nodes using a keyspace
            _client = cluster.Connect(_keySpaceName);
        }
        public async Task Create(ServerDto server)
        {
            var generator = new IdGenerator(0);
            server.ServerId = generator.CreateId();
            var mapper = new Mapper(_client);
            await mapper.InsertAsync(server);
        }
    }
}
