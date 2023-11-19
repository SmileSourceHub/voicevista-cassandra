using System.Numerics;

namespace voicevista_cassandra.DataAccess.Database.Models
{
    public class ServerDto
    {
        public BigInteger ServerId { get; set; }
        public string name { get; set; }
        public List<BigInteger>? CategoryList { get; set; }
        public List<BigInteger>? ChannelList { get; set; }
    }
}
