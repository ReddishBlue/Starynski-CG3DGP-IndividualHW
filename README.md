# Starynski-CG3DGP-IndividualHW
My individual homework from the Hands on Unity textbook.

## Homework 4:
Please open and run **TerrainScene**. Thats where my work for this homework is
- i know the base looks gray but it is NOT greyboxed, I just picked an asset pack that had more gray than i thought. Especially the floor looks like its still a default asset but you can click on them and look, I have a ground asset with its material on there, it just happened to turn out gray-box gray. oops
- i know thegoblin doesnt have a gun, he shoots bullets from his eyes


## Homework 3:

Please open **WorkingScene** and run that! That includes my work from chapters 5 and 6.
The lose scene has a sphere and the win scene has a box.
- worked through chapters 7,8, and 9 in the textbook
- the enemies arent shooting bullets nor are they damaging the player or base but its 10:40 right now!!!
-       edit i think there is a problem in Sight.cs or something because the enemies will get stuck in "go to base"
-       edit again, something is up with player and base attack distances i need to fiddle with them more to get it working i think
-       but if you set the health of enemy or player to 0 to force a win or loss condition, that works properly.

A note on the rigidbodies: the text of the book said to make enemies have Kinematic rigidbodies, however the provided example image for what the components should look like did not have Is Kinematic selected. I selected Is Kinematic since we will be scripting out how enemies should move, but that may change later

## Homework 2:

Please open **WorkingScene** and run that! That includes my work from chapters 5 and 6.

**SampleScene** contains a house I made from that challenge thing at the end of chapter 1. Nothing happens in that scene the house just lives there

**FirstScene** contains the intro stuff from chapters 1 and 2. So like the enemy prefabs, a ball that lands on an incline, etc.

- I worked through chapters 1,2,5, and 6 from the Hands On Unity textbook
- There is a player who moves using the new input system, and enemies which move only forward and spawn in a wave from a spawner
- Code using the old input system is still there but has been commented out, and will be removed in the next homework assignment. I just wanted it there to show I did that part, too.
- a fun little thing I noticed is the enemies rotate when he player runs into them! you can make them run forever in circles if you want. 
- i acknowledge the rotation speed from the mouse is a little scuffed i was really busy this week it'll be fixed for the next homework
