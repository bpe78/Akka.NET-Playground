using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorTradingService.Messages;
using Akka.Actor;

namespace ActorTradingService.Actors
{
    class BotManager : ReceiveActor
    {
        public BotManager()
        {
            Receive<StartBotsMsg>(cmd => OnStartBots(cmd.Configurations));
            Receive<StopBotsMsg>(cmd => OnStopBots());
        }

        void OnStartBots(IEnumerable<int> configurations)
        {
            foreach (var config in configurations)
            {
                var bot = Context.ActorOf<Bot>();
                bot.Tell(new StartMsg(config));
            }
        }

        void OnStopBots()
        {
            foreach (var bot in Context.GetChildren())
                bot.Tell(new StopMsg());
        }
    }
}
