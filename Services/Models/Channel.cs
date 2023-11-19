using System.Numerics;

namespace voicevista_cassandra.Services.Models
{
    public class Channel
    {
        public BigInteger ChannelId { get; set; }
        public BigInteger? CategoryId { get; set; }
        public string name { get; set; }
    }
}
