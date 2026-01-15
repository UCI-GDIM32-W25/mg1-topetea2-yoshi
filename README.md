[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Write your Devlog here!

1. Armando Topete, he/him


2.  My original plan for the MG1 assignment, my main priority was to build the project in two systems: The player controller that handled movement and planting, and a UI system that displayed seed counts whenever each plant was placed. This plan translated directed to the player script, where HandleMovement uses "Horizontal" and "Vertical" axes to support the arrows keys WASD. The planting machanic I planned become the PlantSeed() method, which instantiates my Plant prefab at the player's position and updates _numSeedsLeft and _numSeedsPlanted. These values appeared in the Scene throught the Plant Count Game Object, which holds my PlantCountUI script.

  During the coding process, I made one meaningful change from my initial plan. I initially expected the UI script to be placed on the Canvas GameObject, but after using critical thinking skills, I moved the script into a seperate GameObject to keep the layout and logic cleanly seperated. I also realize it was cleaner to let he Canvas handle the static labels ("Seeds Planted:" and "Seeds Remaining:") and have update only the number fields (Text_SeedsPlantedNum" and "Text_SeedRemainingNum). This prevented duplicated text in the game scene, which makes the UI easier to maintain. I also changed my code from building full strings to simply using .ToString() on the seed values, which fits better with the label and number structure I ended up using for the strings. 

 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
