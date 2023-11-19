using System.Numerics;

namespace voicevista_cassandra.Services.Models
{
    public class Message
    {
        public BigInteger MessageId { get; set; }
        public BigInteger ChannelId { get; set; }
        public string Content { get; set; }
        public string User { get; set; }
    }
}
