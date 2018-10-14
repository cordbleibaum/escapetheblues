using Logic;
using UnityEngine;

public class ScooterAction : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.grandpa.goalFulfilled = true;
		CharacterGroup.instance.timmy.sadness += 10;
		CharacterGroup.instance.uncle.sadness -= 10;
	}
}
