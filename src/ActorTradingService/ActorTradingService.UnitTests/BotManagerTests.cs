using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorTradingService.Actors;
using ActorTradingService.Messages;
using Akka.Actor;
using Akka.TestKit.NUnit3;
using NUnit.Framework;

namespace ActorTradingService.UnitTests
{
    [TestFixture]
    public class BotManagerTests : TestKit
    {
        [Test]
        public void When_BotManagerReceivesStart_CreatesChildren()
        {
            var sut = Sys.ActorOf(Props.Create(() => new BotManager()));
            sut.Tell(new StartBotsMsg(new[] { 1 }));
        }
    }
}
