#if UNITY_EDITOR
using ReplayVR.Core;
using ReplayVR.Models;
#endif
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
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

	protected override void HandleCurrentState(StateArgs e)
	{
		if (e.States[0] is ActionState actionState && actionState.Action == action && e.StateIndex == Index)
		{
			Assert(
				GameObject.Find("ExampleWorldObjects/WorldKeyboard/Input").GetComponent<InputField>().text == "REPLAYVR",
				"Test failed! :(", "Test success! :)");
		}
	}
}
#endif
