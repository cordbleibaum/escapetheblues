using UnityEngine;

namespace Presentation
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    
    public class Tile : MonoBehaviour
    {
        public int PosX;
        public int PosY;

        public float SpaceX;
        public float SpaceY;

        private void Start()
        {
            transform.Translate(new Vector2(PosX*SpaceX, PosY*SpaceY));
        }
    }
}
