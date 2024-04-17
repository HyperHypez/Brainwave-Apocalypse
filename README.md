# Brainwave-Apocalypse

https://docs.google.com/document/d/1zG1gcRiGjr67SdyZKwbdgDmSvfnNr1gnWfaGEjYL5bo/edit?usp=sharing

Game Build: https://drive.google.com/drive/folders/1CrZYfBY7T3gdcNeVnYXn-86N6s_fCH1S?usp=sharing

In our design implementation, we came together to start with the lights and physics. Before the AI and Mecanim implementation, we already had an abundant(>3) amount of lights and physics, and some tweaks were already in. This includes textures to objects of the buildings including rooms, walls, chairs, plants, desks, etc and on the given player weapon, the guns the player has the given textures. Many of the four different zombie types also have their own textures. Throughout the building, more than 40 lights were placed. As for the FPS mechanics, there are sound effects with shooting and reloading. Along with the blood effect when shooting an enemy. These changes add more challenges, detail, and depth to the game. One of the main AI construct implemented into the zombies is the FSM, which uses a simple idle & chase/attack states. The player will need to be more strategic in passing through and fighting the zombies. It has animations for visuals and AI for the added strategic challenges in managing the number of zombies.

Includes various UI elements and sound effects enhancing immersion. Upon opening, a screen menu greets players accompanied by background music setting the tone. During gameplay, players encounter zombie attacks, signified by eerie zombie noises, while gunfire resonates with impactful gunshots. Reloading the gun is accompanied by a player's voice dialogue, adding realism, and sprinting is punctuated by huffing sounds. The UI includes an ammo indicator to track bullet count and a health status indicator for player's survival. Background ambient sounds of dripping water simulate leaky pipes, further enriching the environment. Additional sound effects include player jumping and weapon switching, complemented by background music to sustain the gameplay atmosphere.

Major changes for Assignment 6:

(Jakub Pekala)
- Leaky pipes were added in the office building to add more detail and aesthetics to the building.
- Zombies were added which follows the player. Pathfinding using a nav mesh was the driver behind the zombie AI.
- A walk animation was added to the zombies to satisfy the mecanim requirement.

(Harrison Vu)
- Give the player a bounce-back effect when colliding with zombies in terms of physics. These are strong robotic zombies. Also when zombies are shot, blood particles will appear from them
- Mega Zombie has been utilized as a waypoint AI graph, in patrolling around a route of the map. These are coordinated by many points(spheres) on the map that the zombie follows.
- Given mega zombie an idle and grunting attacking animation as the mecanim.

(Ali Kaleshi)
- Few zombies will a green oder and drippy fluids through the partial system. This adds physics detail to zombies.
- Some zombies have a random idle and patrolling AI path. They will randomly roam at places around the map. It also uses nav mesh.
- Attack and walking animation that is looped for the given mecanim. 


Major changes for Assignment 7:
(Jakub Pekala)
-Start the screen menu when the game is opened before starting the gameplay (UI Element)
-Background music for the start screen.
-Sound effect of zombie noises when they're in attack mode.
-Sound effect of gunshots when shooting.

(Harrison Vu)
-Sound effects for reloading the gun with a player's voice dialogue. 
-Sound effects for the huff when player is sprinting.
-The UI element for the ammo indicator shows how many bullets the player has.
-Background sound for dripping waters to mimic leaky pipes.

(Al Kaleshi)
-Sound effects for player jumping
-Sound effects for the player switching to another weapon.
-Background music during the gameplay.
-Health status to indicate how well the player is (UI Element)



Major changes for Assignment 8:
(Harrison Vu)
-Created and designed intro scene in giving the background of the game.
-Implemented rim lighting shaders, in adding some effects to some zombies.
-Added planes to the stairs so that player can walk up stairs w/o jumping. (Alpha Feedback)
-Added in a helicopter checkpoint for player to reach and finish game. 

(Jakub Pekala)
-Implemented final color (with red tint) shaders to super zombies, giving player easy indication
-Created and designed outro scene in ending the game and to provide credits.
-Fixed scripting for UI and scene switching. After win or lose scene gives you an option to try again. (Alpha Feedback)
-Added an instructions screen to start menu in helping player to figure out controls and goal of game.(Alpha Feedback)

(Al Kaleshi)
-Updated and fixed the health system, where zombies attacks will drain health properly. (Alpha Feedback)
-Added a death screen, when health drained at 0. Will tell player game is over and to try again. (Alpha Feedback)
-Implemented cubemap reflection shaders. To give a few zombies a metallic look  


Further Infomation & References in Design Document



