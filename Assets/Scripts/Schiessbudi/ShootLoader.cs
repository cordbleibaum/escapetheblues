using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootLoader : MonoBehaviour
{
    public GameObject watcher;

    public static GameObject mCam;
    public static GameObject[] mObj;

    private bool done;
    
    private void OnEnable()
    {
        if (done) return;
        done = true;
        
        SceneManager.LoadScene(5, LoadSceneMode.Additive);
        var mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        
        mainCamera.SetActive(false);

        mCam = mainCamera;

        var main = GameObject.FindGameObjectsWithTag("MainScene");

        mObj = main;
        
        foreach (var obj in main)
        {
            obj.SetActive(false);
        }
    }
}
