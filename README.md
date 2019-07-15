# ReplayVR-Demo
Demo project for Replay for Unity (VR) - A (VR) testing framework for Unity. Currently is focused on VR.

Supports:
- VRTK 3.2.1
- SteamVR 1.2.3

# Instructions
The project demo comes with both VRTK and SteamVR (versions supported above).

Getting started:
1. Get the ReplayVR asset from Unity Asset Store and put it inside Plugins folder and Include only Editor platform.
2. Enable "Can record" from Tests/Recorder object.
3. Do your magic.
4. Quit the app.
5. Add the assert conditions to Tests/Asserts, When_Typing_Text_Test component.
6. Restart the app and enable "Can execute" from Tests/Asserts object.
7. See the magic. :)

To view the recording go to Window -> ReplayVR -> Scenario recordings and select the scenario and object you recoreded. The window will output all actions and the corresponding indexes.
