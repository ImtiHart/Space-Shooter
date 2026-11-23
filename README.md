# Space Shooter

A 2D space shooter prototype built in **Unity**. Move the player ship around the screen and fire lasers.

> **Status:** early prototype. The player ship and lasers are in place. Enemies, scoring and game-over logic are not added yet.

## Controls

| Input | Action |
| --- | --- |
| Arrow keys or `W` `A` `S` `D` | Move the ship |
| `Space` | Fire a laser |

## Features

- Smooth movement using Unity's `Horizontal` and `Vertical` input axes
- Laser prefab spawned at the ship's position on each shot
- Screen bounds: when the ship passes the edge of the play area it is moved back to the centre of that axis

## Project Structure

```
Space-Shooter/
└── Assets/
    ├── Scenes/      # Player.unity, Prototype.unity
    ├── Scripts/     # Player.cs
    ├── Prefab/      # Laser.prefab
    └── Materials/   # player_mat, laser_mat
```

## Requirements

- [Unity Hub](https://unity.com/download) and a Unity editor version that can open the project (the repo contains only the `Assets` folder, so Unity will regenerate `Packages` and `ProjectSettings`; use the same version you built it with if you know it)

## Getting Started

1. Clone the repository.
2. In Unity Hub, choose **Add** > **Add project from disk** and select the folder.
3. Open the project, then open `Assets/Scenes/Prototype.unity` (or `Player.unity`).
4. Press **Play**.

> If the repo is missing `ProjectSettings/` and `Packages/`, create a new 2D or 3D project with Unity, then copy the `Assets` folder into it. Add a `.gitignore` for Unity (ignore `Library/`, `Temp/`, `Obj/`, `Logs/` and `UserSettings/`).

## Code Overview

`Assets/Scripts/Player.cs` handles movement and shooting. Attach it to the player object and assign the **Laser prefab** in the Inspector.

## Roadmap

- Laser movement and cleanup when off-screen
- Enemies that spawn and move
- Collisions, health and scoring
- Sound effects and UI
- Game over and restart

## Tech Stack

Unity, C#

## License

No license has been specified yet. Consider adding one, such as MIT.
