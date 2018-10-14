using UnityEngine;

namespace Presentation
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    
    public class Tile : MonoBehaviour
    {
        public bool isLimited;
        public int id;
        public bool once;
        
        public int PosX;
        public int PosY;

        public float SpaceX;
        public float SpaceY;

        public GameObject actionObject;

        private bool done;

        private void Start()
        {
            transform.Translate(new Vector2(PosX*SpaceX, PosY*SpaceY));
        }

        public void OnGoto()
        {
            if (done) return;
            if (once)
            {
                done = true;
            }
            if (actionObject) actionObject.SetActive(true);
        }

        public void OnLeave()
        {
            if (actionObject) actionObject.SetActive(false);
        }
    }
}
