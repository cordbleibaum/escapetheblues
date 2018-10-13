using Logic;
using UnityEngine;

public class FerriswheelAction2 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.timmy.sadness = 0;
		CharacterGroup.instance.timmy.goalFulfilled = true;
		CharacterGroup.instance.uncle.sadness += 10;
		CharacterGroup.instance.grandpa.sadness += 15;
		CharacterGroup.instance.sister.sadness += 5;
	}
}

