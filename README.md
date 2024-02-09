# IMR_PROJECT

## Homework for Lab 5

### State of the Art doc:

https://docs.google.com/document/d/1rEne8sr6C2xZaF7n099P7zNgifMWd9_a/edit?usp=sharing&ouid=109649148439448935787&rtpof=true&sd=true 


## Homework for Lab 6

### Main modules:

https://docs.google.com/document/d/1zagxH3FjtOkC4WKB23HbJ0ESiOsqW8_i/edit?usp=drive_link&ouid=109649148439448935787&rtpof=true&sd=true  


## Progress for Lab 7

In this week:

:smile: we created a Unity Project on Github and started work on our project scene. Also, to work in parallel we used multiple scenes and then merge elements on a main scene

:smile: we started to work on our Eminescu Roundabout Digital Twin: we created the streets, the roundabout, the sidewalks, we added nature elements as the terrain, flowers, trees, grass and sky

:smile: we gray-box modeled our principal buildings: BCU, Palatul Copiilor, CCS and ISP

:smile: we introduced some assets for our treasure-hunt feature: at the moment a blue-flower 

:smile: progress update video: https://www.youtube.com/watch?v=PIWK0LJannw


## Progress for Lab 9

In this week:

:smile: we created a part of UI screens: *How to play*, *Settings*, *Progress* and *BCU* screens

:smile: we added more details on BCU building model

:smile: for the *Treasure hunt* functionality we created 2 scripts which manages the *collected* treasure: after the item is picked up it becomes inactive


## Progress for Lab 10

In this week:

:smile: Added sound effects and vibration when interacting with objects in scene.

:smile: Built app to VR and now we're testing in VR most changes.

:smile: Greatly improved BCU appearance.

:smile: Added Scriptable Objects on the UI elements, so now each building has the same UI template which updates dynamically based on a Scriptable Object

:smile: Reorganized project files into a Project Assets to differentiate imported assets vs our assets (As per teacher's request)

:smile: Added the UI elements in scene, almost done on the game flow

:smile: Added most treasure items, some placeholder in place for now, will replace later. We used some models from Sketchfab for these, which we will modify.

:smile: Changed the hands for the player to the Oculus Quest 3 Controllers

:smile: Started texturing the BCU building

:smile: PROGRESS UPDATE VIDEO: https://www.youtube.com/watch?v=l1_ZgtJFMi0 \[15 December 2023]

:smile: Current BCU appearance: [Click Here!](https://imgur.com/LUyghTV) 

## Progress for Lab 11

In this week:

:smile: Added scriptable object for progress panel to be able to update it dynamically based on the treasure collected 

- When you find a treasure, the black and white image that is on the progress panel, it will then become colored

:smile: On the info panel, we added a base functionality that connects the Info Panel with the Treasure Hunt

- When you find a treasure, the info panel updates using a scriptable object based on the treasure collected. (If you find the Toy Bear -> The info panel updates with info for the Children's Palace building

:smile: Did some improvement on the BCU building texture and fixed a lot of issues with the texture rendering in VR (FIXED ENTIRE BUILDING so it renders properly in VR)

:smile: Attempted to use a 3D Scanning application to 3D scan the statues that would appear in the scene. Further down you'll see the better results [Here are the BAD results scanned with PHONE](https://imgur.com/a/fUoH7QA):

:smile: Added the necessary text for each building and also for the How to play panel. Basically finished the UI, only one left is the Settings panel.

:smile: Started working on the settings panel, basically we have to have separate terrains and skyboxes for each settings. Here's the current settings panel, and for each one we should have a terrain (for seasons) and skyboxes for the different combinations (Summer + Sunny) (Settings panel image)

:smile: Created AI made audio voices which will read the text on each panel when pressing a button for that. Here's a sample of the Children's Palace, voice done by ![Mickey Mouse](https://github.com/pal-Alexandra/IMR_PROJECT/assets/100302933/6043c88b-325e-43b5-8170-7452057765b4) -- [This is the text being read by AI](https://imgur.com/a/YLp01XY)

:smile: Statue of Lapusneanu added in scene - Used Polycam for converting from video to object - We tried recording with phone camera, but with bad results, so tried recording using a drone flying around the statue and we got better results. [CLICK HERE FOR DRONE VIDEO](https://www.youtube.com/watch?v=RgTpxKZPw5s) and also you can [CLICK HERE FOR THE GREAT RESULTS OF STATUE SCAN](https://imgur.com/a/S9TkYHk)

## Progress for Lab 12

:smile: Added weather effects (rain) and skyboxes for the different settings available on the settings panel (we have to connect the functionalities, everything is there)

:smile: Created a script that handles vehicles which follow a path made of game objects, basically vehicles go from point to point and added a tram to the scene and autobuses which infinitely move around

:smile: Added a lot of decoration to the scene - trashcans, street lamps, public benches.

:smile: BIG FEATURE: Added seasons - Created two more terrains, one for autumn and one for winter, the winter one comes with Christmas decorations.

:smile: Added all the AI voices for all buildings, we just have to add a button to play them on the UI (Possibly doing this this week)

:smile: Modified the XR Controllers, now they have additional raycasts, so now you can both interact directly using a XR Direct Interactor but also with a XR Ray Interactor for the UI. 

:smile: Added UI which works with the controllers, just have to add the functionality of each button, most of it is already there, just connecting some assets.

:smile: Moved spawn, extended Pacurari road and the bus & microbus routes and added rail lines for the the trams

:smile: Removed diacritics from buildings text due to font not supporting those characters

:smile: Added a sample script for the settings panel that handles button clicking and volume slider moving

:smile: Removed directional light that illuminated entire scene, added spot lights to street lamps that now illuminate the scene during the night and during the day the skybox illuminates and also tried baking the lights

:smile: Fixed a bug that caused the game to crash when picking up the first treasure hunt item

## Progress for Final Presentation

:smile: Fixed a small issue which caused some vehicles to drive according to UK rules instead of Romania.

:smile: Added humans to roam around the scene that follow a set path

:smile: Added the parking area close to CCS and populated it with cars

:smile: Implemented the entire logic for the settings panel, now you can switch between all settings (Weather, Time of day, Season) and also change the volume of the entire game

:smile: Attempted to use HDRP and it didn't work :(

:smile: Now the info panel appears when you click on a building if the object is collected. A sound is played if successful and a different one if the treasure isn't collected yet

:smile: Added the bus station in the Eminescu, added umbrellas on the Lapusneanu Street (just like in real life)

:smile: Added sidewalks to the entire scene

:smile: The info panel now contains a voice that can read the panel for you, voice generated by AI

:smile: Modified terrain to work with the new changes

:smile: Made the buildings interactable, now you can click on them and also moved entire logic from the Scoreboard manager to each building separately

:smile: Polished almost the entire scene to look better, decorated most places.

:smile: Fixed a bug where you wouldn't hear the object sound effect made when collecting a treasure

:smile: Hidden all the treasure items accordingly so the game is fully playable

## :smile: FINISHED THE PROJECT!

## Necessary assets to download to use in Unity

### Road System:

https://assetstore.unity.com/packages/tools/level-design/road-system-192818

### Bus and tram

https://assetstore.unity.com/packages/3d/vehicles/land/street-vehicles-pack-autobus-tram-213421

### Outdoor Ground Textures

https://assetstore.unity.com/packages/2d/textures-materials/floors/outdoor-ground-textures-12555

https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579

### Skybox

https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633

https://assetstore.unity.com/packages/2d/textures-materials/sky/free-hdr-skyboxes-pack-175525

### Weather effects

https://assetstore.unity.com/packages/vfx/particles/environment/rain-maker-2d-and-3d-rain-particle-system-for-unity-34938

## Nature elements

https://assetstore.unity.com/packages/3d/vegetation/trees/realistic-tree-9-rainbow-tree-54622#content

https://assetstore.unity.com/packages/2d/textures-materials/nature/grass-and-flowers-pack-1-17100?aid=1011ld79j&utm_campaign=unity_affiliate&utm_medium=affiliate&utm_source=partnerize-linkmaker

https://assetstore.unity.com/packages/3d/vegetation/trees/free-english-oak-set-260312 

https://assetstore.unity.com/packages/3d/vegetation/trees/dream-forest-tree-105297 

https://assetstore.unity.com/packages/3d/vegetation/trees/dry-trees-86967

https://assetstore.unity.com/packages/2d/textures-materials/free-sample-materials-112184

## Terrain

In package manager, search Terrain Tools and install it.

## Ornaments

https://assetstore.unity.com/packages/3d/characters/humanoids/humans/santa-claus-rigged-167437 

https://assetstore.unity.com/packages/3d/characters/low-poly-christmas-pack-santa-claus-181035 

https://assetstore.unity.com/packages/3d/props/pbr-snowmen-251152

https://assetstore.unity.com/packages/3d/props/exterior/street-lamps-165658

https://assetstore.unity.com/packages/3d/props/exterior/gaz-street-props-57285

https://assetstore.unity.com/packages/3d/environments/urban/australian-street-sign-pack-213047

https://assetstore.unity.com/packages/3d/props/exterior/electric-scooter-prop-171335

https://assetstore.unity.com/packages/3d/vehicles/land/stylized-vehicles-pack-free-150318

https://assetstore.unity.com/packages/3d/props/exterior/colored-parasols-214006

## Humans

https://renderpeople.com/free-3d-people/

## Sound Effects

https://assetstore.unity.com/packages/audio/sound-fx/free-casual-game-sfx-pack-54116

## Treasure Hunt Assets

stars:
https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-lite-116333
https://assetstore.unity.com/packages/2d/textures-materials/space-star-field-backgrounds-109689
https://assetstore.unity.com/packages/audio/music/stars-17497
https://free3d.com/3d-model/star-v1--893677.html

blue flower:
https://free3d.com/3d-model/crocus-flower-v1--75899.html

book:
https://free3d.com/3d-model/book-pack-93349.html
https://assetstore.unity.com/packages/3d/props/interior/books-3356

quill
https://free3d.com/3d-model/old-scroll-feather-candle-52927.html



