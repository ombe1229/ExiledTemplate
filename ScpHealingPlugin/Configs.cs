using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ScpHealingPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        
        [Description("Use SCP173 healing?")]
        public bool Scp173HealingEnable { get; private set; } = true;

        [Description("SCP173 Healing amount")]
        public int Scp173HealingAmount { get; private set; } = 300;
    }
}