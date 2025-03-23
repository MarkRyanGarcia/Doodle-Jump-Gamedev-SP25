# **Doodle Jump Clone - Unity Workshop** 🚀🎮  

Welcome to the **Doodle Jump Clone** Unity Workshop! In this workshop, you'll learn the basics of **2D game development** in Unity by building a simple **Doodle Jump-style** platformer.  

---

## **🚀 Getting Started**  
1. **Clone this repository**:  

    https:
    ```sh
    git clone https://github.com/MarkRyanGarcia/Doodle-Jump-Gamedev-SP25.git
    ```

    ssh:
   ```sh
   git clone git@github.com:MarkRyanGarcia/Doodle-Jump-Gamedev-SP25.git
   ```

2.	Open the project in Unity's latest version (I am using 6000.0.38f1).

3.	When you open the project, make sure you go to `Scenes` and open the game scene (it should be the only one there, you can't miss it)

4.  Okie you can play now :D

---

## **🎮 How to Play**  
- **Move Left & Right**: `A` / `D` or `Left Arrow` / `Right Arrow`  
- **Jump**: The player jumps automatically when landing on a platform.  
- **Screen Wrapping**: The player wraps around the screen when moving off the edges.  
- **Goal**: Climb as high as possible without falling off the screen!  

---

## **🛠️ Concepts Covered in the Workshop**  
During this workshop, we’ll cover the following Unity game development concepts:  

### **1. Player Movement & Physics**  
- Handling **left & right movement** with `Input.GetAxis`  
- Applying **jump mechanics** using `Rigidbody2D`  
- Implementing **screen wrapping**  
### **2. Collision & Interaction**  
- Detecting collisions with `OnTriggerEnter2D` instead of the usual `OnCollisionEnter2D`
- Allows the player to **pass through platforms on the way up**  
### **3. Platform Spawning & Destruction**  
- Generating **randomly placed platforms**  
- Destroying platforms **once they move off-screen**  
### **4. Camera & Background Scrolling**  
- Making the **camera follow the player** as they ascend  
- Implementing an **infinite scrolling background**  
### **5. UI & Score System**  
- Displaying the **player’s height as a score**

---

## **📂 Project Structure**  
```
/Doodle-Jump-Gamedev-SP25
│── Assets/
│   ├── Sprites/            # Player, platforms, background, UI elements
│   ├── Scripts/            # C# scripts for player, spawner, camera, etc.
│   ├── Prefabs/            # Reusable game objects like platforms
│   ├── Scenes/             # Title screen & main game scene
│── README.md               # This file!

```