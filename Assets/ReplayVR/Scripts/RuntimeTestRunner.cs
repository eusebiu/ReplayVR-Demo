using ReplayVR.Core;
using ReplayVR.Utils;
using UnityEngine;

namespace ReplayVR.Scripts
{
	[AddComponentMenu("ReplayVR/Scripts/RuntimeTestRunner")]
	public class RuntimeTestRunner : MonoBehaviour
	{
		void Start()
		{
			var testObjectName = SystemUtils.GetArgument("replayTestObject:", true);

			if (string.IsNullOrEmpty(testObjectName))
//#if DEBUG
//				testObjectName = "TypeReplayVRTest";
//#else
				return;
//#endif
			testObjectName = testObjectName.Replace("replayTestObject:", string.Empty);

			var testObject = transform.Find(testObjectName);
			if (testObject == null) return;

			testObject.gameObject.SetActive(true);

			var assertBehaviour = testObject.GetComponent<AssertBehaviour>();
			assertBehaviour.Asserting += OnAsserting;
		}

		private void OnAsserting(object sender, bool testResult)
		{
			Application.Quit(testResult ? 0 : -1); // use command "start /wait ReplayVR-Demo.exe replayTestObject:TypeReplayVRTest & echo %errorlevel%" => should see 0
		}
	}
}