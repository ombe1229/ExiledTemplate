using ServerEvents = Exiled.Events.Handlers.Server;
using PlayerEvents = Exiled.Events.Handlers.Player;
using MapEvents = Exiled.Events.Handlers.Map;
using WarheadEvents = Exiled.Events.Handlers.Warhead;
using Features = Exiled.API.Features;
using Log = Exiled.API.Features.Log;

namespace ExiledTemplate
{
    public class exiledTemplate : Features.Plugin<Configs>
    {
        public static bool IsStarted { get; set; }
        public EventHandlers EventHandlers { get; private set; }

        public void LoadEvents()
        {
            ServerEvents.RoundStarted += EventHandlers.OnRoundStarting;
            ServerEvents.RoundEnded += EventHandlers.OnRoundEnded;
            ServerEvents.RestartingRound += EventHandlers.OnRoundRestarting;
        }

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            Log.Info("Plugin is enabled.");
            EventHandlers = new EventHandlers(this);
            LoadEvents();
        }

        public override void OnDisabled()
        {
            ServerEvents.RoundStarted -= EventHandlers.OnRoundStarting;
            ServerEvents.RoundEnded -= EventHandlers.OnRoundEnded;
            ServerEvents.RestartingRound -= EventHandlers.OnRoundRestarting;
        }

        public override void OnReloaded()
        {
            
        }
    }
}