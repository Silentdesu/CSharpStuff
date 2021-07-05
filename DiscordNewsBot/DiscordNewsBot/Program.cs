using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordNewsBot
{
    class Program
    {
        private DiscordSocketClient _client;

        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            var token = "Njg5NzQzMDQzMzM0NTA0NDY5.XnHTRA.APyUOm8UT5afxwl8xn-snfw9LN4";

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage arg)
        {
            Console.WriteLine(arg.ToString());
            return Task.CompletedTask;
        }
    }
}
