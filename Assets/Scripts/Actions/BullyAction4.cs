using Logic;
using UnityEngine;

public class BullyAction4 : MonoBehaviour {
	private void OnEnable()
	{
		CharacterGroup.instance.timmy.sadness -= 15;
	}
}
