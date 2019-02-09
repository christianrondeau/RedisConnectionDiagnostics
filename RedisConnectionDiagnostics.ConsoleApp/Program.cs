using System;
using System.Threading.Tasks;
using RedisConnectionDiagnostics.RedisLib;

namespace RedisConnectionDiagnostics.ConsoleApp
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine(await RedisDiagnosticHelper.Run());
        }
    }
}
