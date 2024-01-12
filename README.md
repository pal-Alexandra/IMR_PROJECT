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

:smile: Started adding NPCs which will roam around the scene using a simple AI

:smile: Statue of Lapusneanu added in scene - Used Polycam for converting from video to object - We tried recording with phone camera, but with bad results, so tried recording using a drone flying around the statue and we got better results. [CLICK HERE FOR DRONE VIDEO](https://www.youtube.com/watch?v=RgTpxKZPw5s) and also you can [CLICK HERE FOR THE GREAT RESULTS OF STATUE SCAN](https://imgur.com/a/S9TkYHk)

## Necessary assets to download to use in Unity

### Road System:

https://assetstore.unity.com/packages/tools/level-design/road-system-192818

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



