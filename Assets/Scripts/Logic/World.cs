using Presentation;
using UnityEngine;

namespace Logic
{
    public class World : MonoBehaviour
    {
        public int StartSadness;
        public int MaxSadness = 100;
    
        public int Width = 4;
        public int Height = 4;

        public Tile[] Tiles;
        public Vector2Int CurrentPosition;
        public Tile CurrentTile;

        private int _sadness;
    
        private void Start()
        {
            _sadness = StartSadness;
        }

        public void GainSadness(int amount)
        {
            _sadness += amount;
            if (_sadness > MaxSadness)
            {
                // GameOver
            }
        }

        public void Move(Direction direction)
        {
            
        }
    }
}
