using System.Collections;
using UnityEngine;

namespace Presentation
{
    public class Teleport: MonoBehaviour
    {
        public int delay = 5;
        
        private void OnEnable()
        {
            StartCoroutine(TeleportFunc());
        }
        
        IEnumerator TeleportFunc()
        {
            yield return new WaitForSeconds(delay);
            Debug.Log("Teleport");
        }
    }
}