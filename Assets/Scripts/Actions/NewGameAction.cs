using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameAction : MonoBehaviour {
    private void OnEnable()
    {
        StartCoroutine(WinDelay());
    }
	
    private IEnumerator WinDelay()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(0);
    }
}
