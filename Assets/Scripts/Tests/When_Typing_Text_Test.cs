using ReplayVR.Core;
using ReplayVR.Models;
using UnityEngine;
using UnityEngine.UI;

public class When_Typing_Text_Test : AssertBehaviour
{
	new void Awake()
	{
		base.Awake();
	}
	new void Start()
    {
		base.Start();  
    }

	// Update is called once per frame
	new void Update()
    {
		base.Update();
	}

	protected override void HandleCurrentState(object sender, StateArgs e)
	{
		if (sender is Component controller)
		{
			if (controller.name == "Controller (right)" || controller.name == "RightHand") // check if the coresponding object has the correct state
			{
				if (e.States[0] is ActionState actionState && actionState.Action == action && e.StateIndex == Index)
				{
					Assert(
						GameObject.Find("ExampleWorldObjects/WorldKeyboard/Input").GetComponent<InputField>().text == "REPLAYVR",
						"Test failed! :(", "Test success! :)");
				}
			}
		}
	}
}
