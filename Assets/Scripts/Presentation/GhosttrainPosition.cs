using UnityEngine;

namespace Presentation
{
    public class GhosttrainPosition: MonoBehaviour
    {
        public static Vector2Int position;

        private void Start()
        {
            var tile = GetComponent<Tile>();
            
            position = new Vector2Int(tile.PosX, tile.PosY);
        }
    }
}