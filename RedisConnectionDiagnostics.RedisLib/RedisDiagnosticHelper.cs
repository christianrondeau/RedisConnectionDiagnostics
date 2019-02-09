using System;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisConnectionDiagnostics.RedisLib
{
    public static class RedisDiagnosticHelper
    {
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("REDISDIAGNOSTICS_CONN") ?? "localhost";
        private const string Key = "RedisDiagnosticHelper:Test";

        public static async Task<string> Run()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Connecting...");
            var connection = await ConnectionMultiplexer.ConnectAsync(ConnectionString);
            var db = connection.GetDatabase(9);
            var value = Guid.NewGuid().ToString();
            sb.AppendLine($"Writing '{value}' to '{Key}'");
            await db.StringSetAsync(Key, value);
            value = await db.StringGetAsync(Key);
            sb.AppendLine($"Read '{value}'");
            return sb.ToString();
        }
    }
}
