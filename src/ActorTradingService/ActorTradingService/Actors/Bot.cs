using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorTradingService.Messages;
using Akka.Actor;

namespace ActorTradingService.Actors
{
    class Bot : ReceiveActor
    {
        private int _botId;

        public Bot()
        {
            ReceiveAsync<StartMsg>(msg => OnStart(msg.Config));
            ReceiveAsync<StopMsg>(msg => OnStop());
        }

        Task OnStart(int config)
        {
            _botId = config;
            Console.WriteLine($"bot {_botId} started");
            return Task.CompletedTask;
        }

        Task OnStop()
        {
            Console.WriteLine($"bot {_botId} stopped");
            return Task.CompletedTask;
        }
    }
}
