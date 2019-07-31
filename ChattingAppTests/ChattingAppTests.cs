using ChattingApp;
using System;
using Xunit;

namespace ChattingAppTests
{
    public class ChattingAppTests
    {
        [Fact]
        public void TestForUser()
        {
            User user = new User();
            user.IPAddress = "0.0.0.0";
            user.Port = 3000;
            Assert.Equal("0.0.0.0", user.IPAddress);
            Assert.Equal(3000, user.Port);
        }
        [Fact]
        public void NetworkListenerNotConnectedTest()
        {
            User user = new User();
            user.IPAddress = "0.0.0.0";
            user.Port = 3000;
            NetworkListener networkListener = new NetworkListener(user);
            Assert.Equal(false, networkListener.IsConnected);
        }
    }
}
