# Assignment 2: Custom Ball Rolling Game in Unity 3D

This custom rolling ball game builds upon the foundational Unity Roll-a-Ball tutorial with new features that add complexity and creativity to the original design. It was built using Unity 3D with custom assets created in Blender and artwork generated with DALL.E.

### Gameplay & Script Explanation

[![GAMEPLAY VIDEO](https://github.com/Raj-Mehta2012/RollBallRoll-Unity3D/blob/main/Assets/Thumbnails/DALL%C2%B7E%202024-09-19%2013.08.23%20-%20A%20dynamic%203D%20game%20scene%20with%20a%20futuristic%20look.%20In%20the%20center%2C%20a%20glowing%20ball%20rolls%20through%20a%20maze%20of%20obstacles%2C%20soaring%20over%20spring-loaded%20cubes%2C%20tel.webp)](https://www.youtube.com/watch?v=raSRCZW0C-E)
[GAMEPLAY VIDEO](https://www.youtube.com/watch?v=raSRCZW0C-E)

[![SCRIPT EXPLANATION VIDEO](https://github.com/Raj-Mehta2012/RollBallRoll-Unity3D/blob/main/Assets/Thumbnails/Screenshot%202024-09-19%20at%202.17.44%E2%80%AFPM.png)](https://www.youtube.com/watch?v=M95SQe67HmE)
[SCRIPT EXPLANATION VIDEO](https://www.youtube.com/watch?v=M95SQe67HmE)

## Game Enhancements
Here are five significant feature enhancements I implemented in the game:

### 1. Blue Rings (Teleportation)
I added blue rings that function as teleporters. These rings transport the player’s ball to another location on the map. To balance this, each teleport has a cooldown of 40 seconds.

- **Code Reference:** `TeleportScript.cs`
- **Snippet:**
```csharp
if (cooldown <= 0) {
    player.transform.position = teleportTarget.position;
    cooldown = 40f; // Reset cooldown
}
```

### 2. Yellow Planes (Springs)
Yellow planes in the game work as springs. When the ball rolls over them, it bounces up with extra force. This feature adds dynamic movement and fun challenges to the game.

- **Code Reference:** `Spring.cs`
- **Snippet:**
```csharp
rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
```

### 3. Green Switches (Sliding Panels)
I incorporated green switches that activate sliding panels. When a player activates a switch, the panel moves downward, causing objects on it to fall. This adds puzzle-like mechanics to the gameplay.

- **Code Reference:** `SwitchScript.cs`
- **Snippet:**
```csharp
platform.Translate(Vector3.down * Time.deltaTime * speed);
```

### 4. Material-Based Speed Variations
The ball’s speed changes depending on the surface material it rolls over. It moves faster on ground surfaces and slower on metal surfaces. This creates a more interactive experience with the environment.

- ***Code Reference:*** `PlayerMovement.cs`
- **Snippet:**
```csharp
if (surfaceMaterial == "Metal") {
    speed = slowSpeed;
} else if (surfaceMaterial == "Ground") {
    speed = normalSpeed;
}
```

### 5. Triggers for Game Retry
I added triggers around the map that reset the game if the ball falls off platforms. This encourages players to stay engaged and navigate carefully.

- **Code Reference:** ``BallFall.cs``
- **Snippet:**
```csharp
if (other.gameObject.CompareTag("FallTrigger")) {
    GameManager.RestartGame();
}
```

### Gameplay Explanation
The core movement is controlled by Unity’s Rigidbody system. The player can guide the ball using the arrow keys, interacting with teleporters, springs, and other game elements.

The camera follows the ball to keep it centered on the screen. I implemented the camera movement with a custom CameraMovement script.

### Licensing and Project Information
The game is developed under the MIT License. All the code provided is custom-written, with inspiration drawn from various Unity tutorials and my creative input. I credited external references where applicable.

[VIEW LICENSE](https://github.com/Raj-Mehta2012/RollBallRoll-Unity3D/blob/main/LICENSE)

Project Name: RollBallRoll
Version: 1.0

### References
- Game Inspiration. https://www.youtube.com/watch?v=bgVvu2JsGEI
- Unity Technologies. Roll a Ball Tutorial. https://learn.unity.com/project/roll-a-ball-tutorial
- Nik Bear Brown. Game Programming Classes Student Work. https://www.youtube.com/playlist?list=PLIS8mRE04MvrZLvLvzZzDV8yqeBasdHfD
- Unity Technologies. Beginner Scripting Course. https://learn.unity.com/course/beginner-scripting
- Unity Technologies. Teaching Game Design and Development. https://learn.unity.com/course/teaching-game-design-and-development
- Unity Technologies. Beginning 3D Game Development. https://learn.unity.com/course/beginning-3d-game-development
- Nik Bear Brown. Unity 5 - Roll a Ball Game Tutorial. https://www.youtube.com/playlist?list=PLX2vGYjWbI0TiP080ELGDurOmz5NAg5CI
- Nik Bear Brown. Roll a Ball Tutorial (Moving the Camera). https://youtu.be/VWeGC4hcJjk
- Nik Bear Brown. Custom Ball Rolling Game. https://www.youtube.com/watch?v=bgVvu2JsGEI
- Image/Splash Screen Generation. https://openai.com/index/dall-e-3/
