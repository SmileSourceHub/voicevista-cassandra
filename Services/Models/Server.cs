using System.Numerics;

namespace voicevista_cassandra.Services.Models
{
    public class Server
    {
        public BigInteger ServerId { get; set; }
        public string Name { get; set; }
        public List<BigInteger>? CategoryList { get; set; }
        public List<BigInteger>? ChannelList { get; set; }
    }
}
