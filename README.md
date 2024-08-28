# TPtool - Nearest Teleport Plugin

**Version:** 1.1  
**Author:** FrankV22  
**Description:** A Terraria plugin that allows players to teleport to the nearest player, NPC, or monster.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
  - [Commands](#commands)
  - [Permissions](#permissions)

## Introduction

**TPtool** is a simple yet powerful plugin for Terraria servers running TShock. It enables players to teleport to the nearest player, NPC, or monster with ease. This can be particularly useful in large worlds where finding other players or specific NPCs can be challenging. By using the provided commands, players can quickly locate and teleport to nearby entities, improving their gameplay experience.

## Features

- **Teleport to nearest player**: Quickly find and teleport to the nearest active player.
- **Teleport to nearest NPC**: Find and teleport to the nearest NPC, including friendly and town NPCs.
- **Teleport to nearest monster**: Locate and teleport to the nearest hostile monster.

## Installation

1. **Download the Plugin**: Download the compiled DLL of TPtool from the [Releases](https://github.com/itsFrankV22/TPtools/releases/tag/TPTools1.1) section of this repository.
2. **Move to TShock Plugins Folder**: Place the `TPtool.dll` file in the `ServerPlugins` folder of your TShock installation.
3. **Restart the Server**: Restart your TShock server to load the new plugin.

### Commands

The following commands are available in TPtool:

| Command     | Description                                           | Usage Example   |
|-------------|-------------------------------------------------------|-----------------|
| `/playertp` | Teleports you to the nearest player.                  | `/playertp`     |
| `/npctp`    | Teleports you to the nearest friendly or town NPC.    | `/npctp`        |
| `/monstertp`| Teleports you to the nearest hostile monster.         | `/monstertp`    |

### Permissions

To control access to each command, TPtool uses specific permissions:

| Permission          | Description                                      |
|---------------------|--------------------------------------------------|
| `tp.tool.tpplayer`  | Allows teleportation to the nearest player.      |
| `tp.tool.tpnpc`     | Allows teleportation to the nearest NPC.         |
| `tp.tool.tpmonster` | Allows teleportation to the nearest monster.     |
