using DotnetOsrsApiWrapper;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace APICallerTest
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            var service = new PlayerInfoService(new HttpClient());
            PlayerInfo playerInfo = await service.GetPlayerInfoAsync("Klavelon");
            PlayerInfo playerInfo1 = await service.GetPlayerInfoAsync("Bun lat ting");

            Console.WriteLine(playerInfo.Cerberus.Score);

            Console.WriteLine(playerInfo1.Cerberus.Score);
        }

    }
}