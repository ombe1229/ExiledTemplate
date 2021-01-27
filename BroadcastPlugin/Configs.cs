using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BroadcastPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Should welcome message be shown?")]
        public bool WelcomeMessageEnable { get; private set; } = true;

        [Description("Welcome message")]
        public string WelcomeMessage { get; private set; } = "Welcome, %PLAYER%!";
    }
}