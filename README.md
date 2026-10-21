# Game Dev Week 2

## Unity version

This project is configured for **Unity 6.6 (6000.6.6f1)**.

The editor version is recorded in `ProjectSettings/ProjectVersion.txt`. Open the project with Unity **6000.6.6f1** to minimize package and serialization changes.

## Open the project on Windows

1. Open Unity Hub.
2. Select **Add > Add project from disk**.
3. Choose this repository's root folder — the folder containing `Assets`, `Packages`, and `ProjectSettings`.
4. Select Unity Editor **6000.6.6f1** if Unity Hub asks which editor to use.
5. Wait for Unity Package Manager to finish resolving packages, then open `Assets/Scenes/SampleScene.unity`.

## Packages

Dependencies are declared in `Packages/manifest.json` and resolved versions are recorded in `Packages/packages-lock.json`. The Universal Render Pipeline dependency is set to **17.6.0**, matching the Unity 6.6 package line.

Do not manually delete or edit `Packages/packages-lock.json` unless you intend to resolve and test package changes in Unity.

## Input handling

The project uses the legacy `UnityEngine.Input` API in `Assets/playerController.cs`. Project input handling is set to **Both** so that the legacy Input Manager API and the Input System package can coexist.

## Build targets

Select a target in **File > Build Profiles**. Windows and Web builds require the corresponding platform modules to be installed in Unity Hub.

## Git notes

Commit project source and settings such as `Assets/`, `Packages/`, and `ProjectSettings/`. Generated folders such as `Library/`, `Temp/`, and `Logs/` are excluded by `.gitignore`.
