using Logic;
using UnityEngine;

public class BullyAction3 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.timmy.sadness += 25;
	}
}
