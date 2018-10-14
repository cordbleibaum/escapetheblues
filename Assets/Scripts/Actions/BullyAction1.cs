using Logic;
using UnityEngine;

public class BullyAction1 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.timmy.sadness += 20;
	}
}
