# Brainwave-Apocalypse

https://docs.google.com/docume      nt/d/1zG1gcRiGjr67SdyZKwbdgDmSvfnNr1gnWfaGEjYL5bo/edit


In our design implementation, we came together in starting off with the lights and physics. Prior to the AI and Mecanim implementation we've already have a abundant(>3) amount of the lights and physics already in with some tweaks. This includes textures to objects of the buildings including walls, chairs, plants, desk, etc and on the given player weapon, the guns the player has the given textures. Throughtout the entirety of the building there is more than 40 lights. As for the FPS mechanics, there are sounds effects with shooting and reload. Along with blood effect when shooting an enemy. Overall, these changes adds more challenges, detail, and depth to the game. The player will need to be more strategic in passing through and fighting the zombies. It has animations for visuals and the AI for the added strategic challenges in managing number of zombies.

Major changes for Assignment 6:

(Jakub Pekala)
- Leaky pipes were added in the office building to add more detail and aesthetic to the building.
- Zombies were added which follow the player. Pathfinding using a nav mesh was the driver behind the zombie AI.
- A walk animation was added to the zombies to satisfy the mecanim requirement.

(Harrison Vu)
- Given player a bounce back effect when colliding with zombies, in terms for physics. These are strong robotic zombies. Also when zombies are shot, blood particle will appear from them
- Mega zombie has been utlizes a waypoint AI graph, in patroling around a route of the map. These are coordinated by a lot of points(spheres) on the map that zombie follows.
- Given mega zombie an idle and grunting attacking animation as the mecanim.

(Ali Kaleshi)
- Few zombies will a green oder and drippy fluids through the partial system. This adds physics detail to zombie.
- Some zombies have a random idol and patrolling AI path. They will randomly roam at places around the map. Also uses nav mesh.
- Attack and walking animation that is looped for the given mecanim. 

Further Infomation & References in Design Document
