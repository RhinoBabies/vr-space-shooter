# vr-space-shooter
#### by Justin Vessey - CS485 with Dr. Xin Ye

In vr-space-shooter, you command a stranded space vessel in a deep region near the Nicodemus Nebula. Your ship barely has enough resources to send an emergency beacon, but, with no way to receive a confirmation signal, all you can do is *wait*.

The ship has managed to recover some energy in the form of cubes of foreign matter. Luckily, this provides enough juice to defend your ship against any incoming asteroids. **Will you be able to survive long enough to be rescued?**
##
### Supported Devices
As the title suggests, this game must be played with a Google Cardboard-enabled device and was specifically designed for use with an Android phone with at least KitKat 4.4 installed.

The game can be played with a VR-headset featuring a capacitive touch button; however, when the Game Ends, the player will have to restart the app in order to restart the game. It is best played in conjunction with a generic Bluetooth controller whose button pushes include "Fire" and "Jump," or, respectively, "LeftMouseClick" and "Spacebar," as the controller would output if configured for keyboard input. This allows a player to push the "Jump" button to restart the game without having to remove their VR headset or head-mounted display (HMD).

### How to Play
Playing the game is simple! Aim the spaceship reticle by moving your head towards your target. Push the corresponding "Fire" button to shoot a laser towards the reticle. With precision and speed, you will survive long enough to be rescued.

### References
vr-space-shooter utilizes the [GoogleVR SDK for Unity](https://github.com/googlevr/gvr-unity-sdk) and requires certain GoogleVR (GVR) components for functionality, namely the GvrEditorEmulator and GvrReticlePointer GameObjects.

Most of this game derives from the [Unity Space Shooter tutorial](https://unity3d.com/learn/tutorials/projects/space-shooter-tutorial). The largest difference (and obstacle) was dealing with objects in more of a 3D space, since the tutorial is mostly constrained to a 2-dimensional playing field.

### Design Choices and Personal Contributions
Asteroids spawn from the front quad of the game so as not to overwhelm the player, especially if this is their first time playing a VR game. However, the asteroids aim directly at the player and it takes only one impact to lose the game. Power-up and negative cubes were added to the game to change the pace of the game. Hazards increment with each wave to steadily increase the difficulty of the game. Red arrows indicate the direction of asteroids that cannot currently be seen by the player.

### Future Improvements
* Implementing Score Text similar to what is done in the Unity Space Shooter tutorial.
* Interfacing with the GvrEventSystem to change the reticle when a valid target is being pointed at with the GvrPointerPhysicsRaycaster.
* Fine-tune the HUD warnings for more specific directional guidance to hazards and some type of animation.
* Change the spawn locations and directions of asteroids so not all instances pose a risk to the player.
* Display a message that tells the player when another wave of asteroids is approaching.
* HUD radar that displays an overhead view of the player and nearby objects.
* Powering up the lasers by firing multiple shots at once either all towards the reticle or in a spread pattern.

### What I Learned
Much of what I learned occured during the Unity Space Shooter tutorial and then I tried to replicate those ideas into this rendition of the game. I learned about the following topics: Lighting, Prefabs, Audio Sources, Colliders, Triggers, Coroutines, and Google VR. Merging Unity projects is also quite cumbersome; I tried to branch two versions of the Space Shooter game, one with the PlayerController implemented and another with the background graphics. This resulted in reminding myself of the necessary Unity Editor Settings (Visible Meta Files and Force Text) and having to redo a portion of the project. 
