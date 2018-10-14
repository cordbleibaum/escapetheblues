using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAction : MonoBehaviour {
	public void Play()
	{
		SceneManager.LoadScene(1);
	}
}
