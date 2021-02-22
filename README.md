# BELT SYSTEM IN VIRTUAL INDUSTRY
<p align="right">@Updated Feb 23, 2021</p>   

This repository for IITP project. </br></br>

## Prepraing the VR project: Installation
1. Unity 2019.2.18f

## Overview

1.The experiment consists of four sessions: training session and level 1,2,3.

2.The training session takes about one minute, and aims to learn how to adapt to the VR environment and start the test.

3.The game has a total of 20 items per session, and if you have classified all of them, you will automatically go to the next session. Please check the signboard and touch the game start button again. Please repeat to Level 3.

4.This game is set to allow the participants to perform the task at a reasonable speed, and the higher the level, the shorter the interval the object comes out.


## Description


<img width="235" alt="2" src="https://user-images.githubusercontent.com/58596672/95021250-d86a8a80-06aa-11eb-9dee-54ab0ea71099.PNG">

1) Game level status display and count display panel
  - A sign for participants to visually notify their current level status and the waiting time of 5 seconds after pressing the game button.


2) The trash bin for throwing away the items
  - There are four types of trash bins in total.
  - The location of the trash bins randomly placed in each session is changed.


<img width="241" alt="3" src="https://user-images.githubusercontent.com/58596672/95021252-de606b80-06aa-11eb-9972-4ac9575a1771.PNG">

3) Catch items
  - Press the trigger button on the controller before the object falls off the belt to catch it. You can catch it without reaching out much.


4) Classification of items
  - Put the items in the trash bin that match the type of item.
  - The label of the trash bin shine to inform the status that you can throw it in the trash bin  you caught.

## Raw Data Collection

### Head
  - Position(x,y,z)
  - Rotation(x,y,z,w)

### Hand
  - Position(x,y,z)
  - Rotation(x,y,z,w)

## User Data Collection

### Hand
  - Hesitation : the number of hesitating times detected in the trash bin area after article is caught
  - Action Time : cumulative time until you hold and drop things
  - Comission Error : Number of errors if you missed or misresponded to an item
  - Collect : Number of collect if you responded to right item.
  - Color-interference : The type of item type is different, but the subject responded to the same color.
