using System.Collections.Generic;

namespace ActorTradingService.Messages
{
    class StartBotsMsg
    {
        public StartBotsMsg(IEnumerable<int> configurations)
        {
            Configurations = configurations;
        }

        public IEnumerable<int> Configurations { get; private set; }
    }
}
