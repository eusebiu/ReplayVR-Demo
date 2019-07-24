# ReplayVR-Demo
Demo project for Replay for Unity (VR) - A (VR) testing framework for Unity. Currently is focused on VR.

Supports:
- VRTK 3.2.1, 3.3.0
- SteamVR 1.2.3

# Instructions
The project demo comes with both VRTK and SteamVR (versions supported above).

Getting started:
1. Get the ReplayVR asset from Unity Asset Store and put it inside a Plugins folder and set platforms for the libraries (ReplayVR.dll for all platforms, ReplayVR.Editor.dll only for Editor).
2. Add VRTK ReplayVR components to Controllers and Camera using Add Component in UnityEditor (see ReplayVR section); for camera you also need to add Tracked Pose Driver from XR Legacy Input Helpers.
3. Create a Tests/Recorder game objects and assign it the ScenarioRecorder component from ReplayVR; enter a scenario name and enter the recorders (controllers and camera).
4. Play the app.
5. Enable "Can record" from Tests/Recorder object.
6. Do your app flow.
7. Quit the app - the objects movements and actions will be stored in Application.physicalPath location.
8. Add the Tests/Asserts game object and assign it a new MonoBehavior that inherits from AssertBehaviour from ReplayVR; implement HandleCurrentState. Add the runners and scenario name same as the recorder.
9. Set the conditions to the assert component.
10. Enable "Can execute" of the assert component.
11. Restart the app.
12. See the app flow replayed

To view the recording go to Window -> ReplayVR -> Scenario recordings and select the scenario and object you recoreded. The window will output all actions and the corresponding indexes.

## Troublesh0oting
Set ReplayVR.dll available for all platforms and ReplayVR.Editor.dll only for Editor platform.

## Video
[![ReplayVR Is AWESOME](https://img.youtube.com/vi/-IUC0XG-LZA/0.jpg)](https://www.youtube.com/watch?v=-IUC0XG-LZA "ReplayVR Is AWESOME")

## Demo recordings
Copy the files to Application.physicalPath:
e.g.: C:\Users\<user>\AppData\LocalLow\ReplayVR\ReplayVR-Demo\ReplayVR\Recordings
