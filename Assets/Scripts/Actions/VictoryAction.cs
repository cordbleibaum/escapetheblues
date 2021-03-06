﻿using System.Collections;
using Logic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryAction : MonoBehaviour {
	private void OnEnable()
	{
		if (!CharacterGroup.instance.timmy.goalFulfilled) return;
		if (!CharacterGroup.instance.sister.goalFulfilled) return;
		if (!CharacterGroup.instance.uncle.goalFulfilled) return;
		if (!CharacterGroup.instance.grandpa.goalFulfilled) return;
		StartCoroutine(WinDelay());
	}
	
	
	private IEnumerator WinDelay()
	{
		yield return new WaitForSeconds(4);
		SceneManager.LoadScene(3);
	}
}
