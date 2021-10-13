EnginesLab4

Music is From ZUN, PCB Stage 5 - Mystic Oriental Dream ~ Ancient Temple.
I just made the crash bandicoot version you hear.

I used a singleton for the button counter. The scene gets reopened, but the singleton
is used once and  is not created again. It persists and counts no matter how many times you 
re-open the scene.

Music was added through an onButtonPress() function.
Using an audio source, it plays the track whenever clicked and restarts it if clicked while 
the track is already playing. 

Original soundtrack from ZUN can be found on Youtube: 
https://www.youtube.com/watch?v=nW93YFbawPU&ab_channel=Louchan2

Code was taken and used from my previous lab work and lectures and personal projects. 
Singleton code was utilized from the lab4 recordings.

Repo is from Hossain Alinaqi
Student Number: 100761694