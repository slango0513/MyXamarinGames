using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace MyMonoGame
{
    public class TestingClass
    {
        public async Task StartAsync()
        {
            var hubConnection = new HubConnectionBuilder()
                .WithUrl($"http://10.0.0.3:8000/relaying")
                .Build();

            try
            {
                //await hubConnection.StartAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Exception: {e}");
            }
        }
    }
}
