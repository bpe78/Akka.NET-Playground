using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorTradingService.Actors;
using ActorTradingService.Messages;
using Akka.Actor;

namespace ActorTradingService
{
    class Program
    {
        static void Main(string[] args)
        {
            var actorSystem = ActorSystem.Create("mySystem");

            var botManager = actorSystem.ActorOf<BotManager>();
            botManager.Tell(new StartBotsMsg(new[] { 1, 2, 3, 4, 5 }));

            Task.Delay(1000).Wait();
            botManager.Tell(new StopBotsMsg());

            actorSystem.Terminate().Wait();
        }
    }
}
