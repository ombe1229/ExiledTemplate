using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

namespace ExiledTemplate
{
    public class EventHandlers
    {
        private readonly myPlugin _pluginInstance;
        public EventHandlers(myPlugin pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnRoundStarting()
        {
            if (!_pluginInstance.Config.IsEnabled) return;
            myPlugin.IsStarted = true;
            Map.Broadcast(10, "Round has been started.");
        }

        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            myPlugin.IsStarted = false;
            Map.Broadcast(10, "Round has been ended.");
        }

        internal void OnRoundRestarting()
        {
            myPlugin.IsStarted = false;
        }
    }
}