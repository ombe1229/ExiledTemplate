# BroadcastPlugin

## Description

When a player joined the server, the custom message is formatted and broadcasted.
The broadcast is only visible to the player concerned.

## Configs

| Config               | Type   | Default value      | Description                                                       |
| -------------------- | ------ | ------------------ | ----------------------------------------------------------------- |
| is_Enabled           | bool   | true               | Whether to use the plugin                                         |
| welcomeMessageEnable | bool   | true               | Whether to broadcast when the player is joined.                   |
| welcomeMessage       | string | Welcome, %PLAYER%! | Text to broadcast (%PLAYER% will be formatted to player nickname) |
