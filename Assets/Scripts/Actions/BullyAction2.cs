using Logic;
using UnityEngine;

public class BullyAction2 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.timmy.sadness += 15;
	}
}
