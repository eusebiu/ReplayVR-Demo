# ReplayVR-Demo
Demo project for Replay for Unity - A VR testing framework for Unity.

Tested on:
- VRTK 3.2.1, 3.3.0
- SteamVR 1.2.3
- HTC Vive, VRTK Simulator (also tested recording on HTC Vive and played on simulator) (Oculus support is comming)

Currently, the recording is supported only in Unity Editor.

# Instructions
The project demo comes with both VRTK and SteamVR (versions supported above).

Getting started:
1. Get the ReplayVR asset from Unity Asset Store (https://assetstore.unity.com/packages/tools/gui/replayvr-150493) and put it inside a Plugins folder and set platforms for the libraries (ReplayVR.dll for all platforms, ReplayVR.Editor.dll only for Editor).
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

SteamVR:
- Controllers - see LeftController(ScriptAlias)/RightController(ScriptAlias) VRTK objects
- Camera - see Camera (eye) object

Oculus (untested):
- Controllers - see LeftController(ScriptAlias)/RightController(ScriptAlias) VRTK objects
- Camera - see CenterEyeAnchor

To view the recording go to Window -> ReplayVR -> Scenario recordings and select the scenario and object you recoreded. The window will output all actions and the corresponding indexes.

Running a test at runtime (can be used in CI environments):
1. Add the RuntimeTestRunner from ReplayVR.Scripts to the root TestObject (provided by the asset)
2. Build the app for Standalone player
3. Run the command from Command Prompt "start /wait <app>.exe replayTestObject:Unity_test_object & echo %errorlevel%" => you should see 0 if test is successful, -1 if not.

Remarks:
a. Unity_test_object is the name of the object in Unity that has the AssertBehaviour component attached to it.
b. For other platforms, see the corresponding commands to start and app and get it's exit code.

## Troublesh0oting
Set ReplayVR.dll available for all platforms and ReplayVR.Editor.dll only for Editor platform.

## Video
[![ReplayVR Is AWESOME](https://img.youtube.com/vi/-IUC0XG-LZA/0.jpg)](https://www.youtube.com/watch?v=-IUC0XG-LZA "ReplayVR Is AWESOME")

## Demo recordings
Copy the files to Application.physicalPath:
e.g.: C:\Users\<user>\AppData\LocalLow\ReplayVR\ReplayVR-Demo\ReplayVR\Recordings
