using Logic;
using UnityEngine;

public class FerriswheelAction4 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.uncle.sadness -= 10;
		CharacterGroup.instance.grandpa.sadness += 10;
	}
}

