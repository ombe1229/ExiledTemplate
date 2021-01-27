using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

namespace BroadcastPlugin
{
    public class EventHandlers
    {
        private readonly broadcastPlugin _pluginInstance;
        public EventHandlers(broadcastPlugin pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnRoundStarting()
        {
            if (!_pluginInstance.Config.IsEnabled) return;
            broadcastPlugin.IsStarted = true;
        }

        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            broadcastPlugin.IsStarted = false;
        }

        internal void OnRoundRestarting()
        {
            broadcastPlugin.IsStarted = false;
        }

        internal void OnPlayerJoined(JoinedEventArgs ev)
        {
            if (!_pluginInstance.Config.WelcomeMessageEnable) return;
            Player evPlayer = ev.Player;
            string welcomeMessage =
                _pluginInstance.Config.WelcomeMessage.Replace("%PLAYER%", evPlayer.DisplayNickname);
            evPlayer.Broadcast(10, welcomeMessage);
        }
    }
}