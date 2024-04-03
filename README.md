# Brainwave-Apocalypse

https://docs.google.com/document/d/1zG1gcRiGjr67SdyZKwbdgDmSvfnNr1gnWfaGEjYL5bo/edit?usp=sharing

In our design implementation, we came together to start with the lights and physics. Before the AI and Mecanim implementation, we already had an abundant(>3) amount of lights and physics, and some tweaks were already in. This includes textures to objects of the buildings including rooms, walls, chairs, plants, desks, etc and on the given player weapon, the guns the player has the given textures. Many of the four different zombie types also have their own textures. Throughout the building, more than 40 lights were placed. As for the FPS mechanics, there are sound effects with shooting and reloading. Along with the blood effect when shooting an enemy. These changes add more challenges, detail, and depth to the game. One of the main AI construct implemented into the zombies is the FSM, which uses a simple idle & chase/attack states. The player will need to be more strategic in passing through and fighting the zombies. It has animations for visuals and AI for the added strategic challenges in managing the number of zombies.

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

Further Infomation & References in Design Document
