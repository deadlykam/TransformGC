# TransformGC
### Introduction:
This project is created to investigate garbage created from calling _transform_ field for first time in Unity3D Game Engine.
***
## Unity Game Engine
Unity3D version build is **2020.3.3f1**.
***
### Instructions:
1. Open the Profiler and enable the Deep Profile and Call Stacks.
2. Open the build settings and enable Development Build, Autoconnect Profiler and Deep Profiling Support.
3. Build the game.
4. After building the game run.
5. Let the game run for few seconds till the first GC spike is gone.
6. After that press the "T" button repeatedly.
7. One GC Alloc spike will come up and then exit the game by pressing "Esc" button.
8. Click the GC Alloc spike which should show about 36B, may change for different machines.
9. Keep following the GC spike down to the source and you will come to _Component.get_transform()_ which triggers this GC Alloc spike because of calling it for first time.
***
