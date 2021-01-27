using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

namespace ScpHealingPlugin
{
    public class EventHandlers
    {
        private readonly scpHealingPlugin _pluginInstance;
        public EventHandlers(scpHealingPlugin pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnRoundStarting()
        {
            if (!_pluginInstance.Config.IsEnabled) return;
            scpHealingPlugin.IsStarted = true;
            Map.Broadcast(10, "Round has been started.");
        }

        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            scpHealingPlugin.IsStarted = false;
            Map.Broadcast(10, "Round has been ended.");
        }

        internal void OnRoundRestarting()
        {
            scpHealingPlugin.IsStarted = false;
        }

        internal void OnPlayerDied(DiedEventArgs ev)
        {
            if (ev.Killer.Team != Team.SCP || !_pluginInstance.Config.Scp173HealingEnable) return;
            if (ev.Killer.Health + _pluginInstance.Config.Scp173HealingAmount >= ev.Killer.MaxHealth)
            {
                ev.Killer.Health = ev.Killer.MaxHealth;
            }
            else
            {
                ev.Killer.Health += _pluginInstance.Config.Scp173HealingAmount;
            }
            ev.Killer.Broadcast(10, "You have recovered <color=red>10</color>hp by killing human.\n" +
                                    $"Current HP : <color=red>{Math.Truncate(ev.Killer.Health)}</color>");
        }
    }
}