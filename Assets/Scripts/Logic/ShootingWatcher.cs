using UnityEngine;

namespace Logic
{
    public class ShootingWatcher : MonoBehaviour
    {
        private bool isUsed;
        
        private void Update()
        {
            if (isUsed) return;
            
            if (BlinkingTarget.gameOver)
            {
                isUsed = true;

                var mainCamera = ShootLoader.mCam;
        
                mainCamera.SetActive(true);

                var main = ShootLoader.mObj;

                foreach (var obj in main)
                {
                    obj.SetActive(true);
                }

                CharacterGroup.instance.uncle.sadness -= BlinkingTarget.score / 150;

                World.instance.canSlide = true;
                
                Destroy(gameObject);
            }
        }
    }
}