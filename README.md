# Galaxy Game
A casual puzzle video game where you must save various worlds and universes infested with slimes. Solve each level by the power of physics, unlock new levels, and discover different slimes throughout the universe.
<br></br>

## Introduction
### Core Gameplay
This game is inspired by most physics-based games as well as casual video games like Angry Birds. For the player to complete the game, he needs to solve each puzzle by killing all the enemies in each level (currently 10 levels). The player needs to think about the right position and timing of the projectiles fired to ensure that every enemy is killed.  
### Genre
Galaxy Game is a casual puzzle physics-based video game.  
<br></br>

## Narrative
### Theme
The philosophical ideas behind the game are alien/otherworldly, galaxies, and slimes.
### Story
The universe is peaceful until the slime god decides to invade the whole universe. It sent its abominations into various places in the universe and started to infest everything with slime. Earth, one of the worlds and civilizations which got infested with slimes tried to retaliate and push back the slime god’s abominations but failed to do so until an unknown being showed up and helped Earth to regain its control. It is now up to this unknown being to stop the slime god and save various worlds and the universe from its complete and utter destruction. 
### Characters
![Player](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/c4a82b77-1430-421c-9c29-525ca894fd34)
#### Unknown Being 
This being saved the Earth when it was on the brink of its destruction. Now, it’s up to this being to save the whole universe from the slime god’s invasion. You, the player will be this unknown being and it's up to you to save the world. You have various projectiles at your disposal.
#### Projectiles

- Normal Projectile ![NormalProjectile](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/9d8be2ba-9781-41ea-b0d4-7f5f73c82218)
  - Low Power (10 Force Factor)
  - Moderate Trajectory Path Length (10 dots)
  - No special skills
- Heavy Projectile ![HeavyProjectile](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/e42dec6b-d85f-4848-a7bc-29f6e61720f1)
  - High Power (10 Force Factor * Mass)
  - Short Trajectory Path Length (5 dots)
  - Heavy and Big
- Speed Projectile ![ExplosiveProjectile](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/e12b2989-7320-4f34-8237-921089399eec)
  - Medium Power (20 Force Factor)
  - Long Trajectory Path Length (15 dots)
  - High Speed (can bypass certain obstacles)
#### Obstacles
- Wood  ![Wood](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/4539e4cf-0cde-418c-a118-7199932e10f5)
        ![GreenWood](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/99f108ac-49a1-47b9-9a96-2ee57561de18)
        ![VioletWood](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/d853b366-8022-44a1-a1f1-6b1bb4bbcd66)
  - Low Mass (0.05 in rb)
- Brick ![Brick](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/9d579e67-4cb4-4fac-8cba-9a616f772c25)
        ![GreenBrick](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/dcb0c83d-1c4e-405c-b6f7-3ea5efa7ae58)
        ![VioletBrick](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/25944f2c-752d-4428-8c29-01a620a39ada)
  - Medium Mass (0.5 in rb)
- Crystal ![Crystal](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/23bfb349-f4b1-496f-ad28-f3c099f3a854)
          ![AlienCrystal](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/713b2959-9ac0-401a-9c76-dae3abce7734)
          ![LavaCrystal](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/7cac9a15-a70a-47ec-86a2-8bd1faaca819)
  - High Mass (5 in rb)
#### Enemies
![NormalSlime](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/42a58f27-062d-4b8e-a1ed-29c312d53549)
- Normal Slime  
  - Low amount of HP (10 HP) 
  - Recognized by its green color and plain features

![RockSlime](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/90a1f8ab-085b-4f3c-a208-41d1be10408d)
- Rock Slime 
  - Moderate amount of HP (30 HP)
  - Recognized by its brown color and some sort of head armor

![CrystallizedSlime](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/32971b26-570c-4b26-b151-0e04c9fb1f83)
- Crystal Slime 
  - High amount of HP (50 HP)
  - Recognized by its dark blue color and crystals growing on its top.
  - Typically, bigger than other slimes.
<br></br>

## Settings
### Universe
- Earth
- Various Alien Worlds
<br></br>

## Level Design and Gameplay
### Game Progression and Level Outline
- Once the player starts the application, the player will be able to hear a piece of background music and will continue to play even after switching scenes.  

![Screenshot 2023-12-03 212512](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/85c87bc3-c71b-4d43-a6b6-94e94a95b080)
- In the main menu, the player will be able to choose to “Start” the game, “Resume” the game, or “Quit” the game. The “Resume” button will be not interactable by default if the player hasn’t started any levels. This button will load the last level that the player played.
- If the player, clicks the “Start” button, another scene will be loaded which will show the available levels that are unlocked in the player’s playtime. By default, Stage 1 will be the only available level. The players will be able to unlock the other levels once they reach it.  

![Screenshot 2023-12-03 212525](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/f1f4d63e-fa62-4e19-b001-52147c2c94fa)
- A “Home” button will also be present which will put the player back into the main menu. A “Reset” button will also be present to restart the player’s game progress.

![Screenshot 2023-12-03 212641](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/1369c893-28ee-49f6-bad4-d1b2eb50d418)
![Screenshot 2023-12-03 213029](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/cd3cd300-621b-4763-945c-f5d23964c533)
- Upon choosing a level (e.g. Level 1). This should be the UI which includes:
  - Home Button (Go to Main Menu)
  - Retry Button (Restart the current level)
  - Level Title (Shows the current level)
  - Score (Shows the score on the level, this will automatically increment depending on which type of enemy the player kills)
  - Player (the player sprite)
  - Projectiles (Position to generate the projectiles)
  - Enemy Area (Slime and Obstacle area)
- Each level has a specified number of projectiles that the player can use. Each level also presents different kinds of obstacles and enemies to kill which depends on the level.  

![Screenshot 2023-12-03 212659](https://github.com/franzdar/GalaxyGame-Project/assets/152060348/82cf0583-6e67-4308-b5aa-7058592c6416)
- If the player has no projectiles left (5 available for all levels, 10 for Level 10) the game will show two buttons, “Restart” and “Exit”.
  - If the player chooses “Restart” the current level will restart.
  - If the player chooses “Exit” the player will go back to the main menu.
- Once the player finishes Level 10, the player will be sent back to the Level Select scene in which they can choose to either replay their favorite level or restart their game progress by using the restart button.
#### Score System:
  - Normal Slime = +1000 pts
  - Rock Slime = +5000 pts
  - Crystal Slime = +10000 pts  

### Level Objectives
- Eliminate all enemies
- Gain the maximum score









