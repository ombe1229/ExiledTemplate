using Exiled.API.Interfaces;

namespace MyPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}