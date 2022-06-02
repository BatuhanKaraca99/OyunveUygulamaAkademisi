=== NERA SPRITE PACK ver 2.1 ===
A metal slug inspired sprite pack. 
Includes sprites of a soldier girl named Nera.

=== CHANGELOG ===
2.1 - Fixed shoot_up_end animation containing leg sprites
2.0 - Added hurt animations, effects, and demo game
1.0 - Initial Release

=== USAGE ===
Sprites are designed for a metal slug styled game, where the leg and torso states are independent.
As a result, there are usually two sets of sprites for each animation, which can be used in different combinations.
Transitional sprites are also included, marked the "start" or "end" prefix.


=== SPRITE LIST ===
 Folder location: l = leg, t = torso

 - idle (l/t): Basic idle. Torso can be swap for shoot.
 - idle_alt (l): Alternate idle. Doesn't really fit with the rest of the pack.
 - shoot (t): Shooting.

 - run (l/t): Run. For all run sprites, torso can be swap for shoot, but should be offset up one pixel.
 - run_start (l/t): Transition from idle to run.
 - run_stop (l/t): Transition from run to idle.

 - jump (l): Jump legs. Works with idle and shoot torso

 - crouch_idle (l): Crouching idle.
 - crouch_move (l): Moving while crouched.
 - crouch move start-end (l): Single frame transition between idle and move
 - crouch_shoot (l): Shooting while crouched. Should be stationary.
 - crouch_start (l): Transition from idle/run to crouch.
 - crouch_end (l): Transition from crouch to idle

 - look_up (t): Idle, but looking up
 - shoot_up (t): Shooting upwards. Works with any sprite that the regular 'shoot' works with.
 - shoot_up_start (t): Look-up to shoot-up
 - shoot_up_end (t): Shoot-up to look-up
                                                                                                         
 - melee_knife (l): Full body, two-hit melee attack.     

 - hurt (l): Full body, some knockback is recommended
 - death_ground (l): Full body, gun drop effect is recommended                                                                                   


=== NOTES ===
 - Sprites that are not split into legs and torso (crouch and melee) will be located in the leg folder
 - All sprites anchor point are CENTERED


=== CREDITS ===
Credits (just mention 'poohcom1') are required, unless you donate. 