namespace ActorTradingService.Messages
{
    class StartMsg
    {
        public StartMsg(int config)
        {
            Config = config;
        }

        public int Config { get; private set; }
    }
}
