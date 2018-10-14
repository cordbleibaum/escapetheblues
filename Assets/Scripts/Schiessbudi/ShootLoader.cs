using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootLoader : MonoBehaviour {
    private void OnEnable()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Additive);
        var mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        
        mainCamera.SetActive(false);

        var main = GameObject.FindGameObjectsWithTag("MainScene");

        foreach (var obj in main)
        {
            obj.SetActive(false);
        }
    }
}
