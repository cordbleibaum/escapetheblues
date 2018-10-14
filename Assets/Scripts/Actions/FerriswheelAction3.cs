using Logic;
using UnityEngine;

public class FerriswheelAction3 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.uncle.sadness -= 10;
	}
}

