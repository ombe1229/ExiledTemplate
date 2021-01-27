# ScpHealingPlugin

## Description

When an SCP kills a human, it restores HP and informs by broadcast.
The broadcast is only visible to the SCP concerned.

## Configs

| Config              | Type | Default value | Description                                                       |
| ------------------- | ---- | ------------- | ----------------------------------------------------------------- |
| is_Enabled          | bool | true          | Whether to use the plugin                                         |
| Scp173HealingEnable | bool | true          | Whether SCP173 will regain physical strength when it kills human. |
| Scp173HealingAmount | int  | 300           | The amount of HP that SCP173 will recover when it kills human.    |
