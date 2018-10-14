using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {
	private void Start ()
	{
		StartCoroutine(RespawnDelay());
	}
	
	private IEnumerator RespawnDelay()
	{
		yield return new WaitForSeconds(4);
		SceneManager.LoadScene(1);
	}
}
