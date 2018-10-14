using UnityEngine;
using UnityEngine.SceneManagement;

namespace Actions
{
    public class IntroAction : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene(1);
        }
    }
}