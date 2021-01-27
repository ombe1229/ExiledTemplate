using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

namespace ExiledTemplate
{
    public class EventHandlers
    {
        private readonly exiledTemplate _pluginInstance;
        public EventHandlers(exiledTemplate pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnRoundStarting()
        {
            if (!_pluginInstance.Config.IsEnabled) return;
            exiledTemplate.IsStarted = true;
            Map.Broadcast(10, "Round has been started.");
        }

        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            exiledTemplate.IsStarted = false;
            Map.Broadcast(10, "Round has been ended.");
        }

        internal void OnRoundRestarting()
        {
            exiledTemplate.IsStarted = false;
        }
    }
}