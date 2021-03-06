
namespace Qrcode.Flow.API.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
