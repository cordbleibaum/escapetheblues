using Presentation;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Logic
{
    public class World : MonoBehaviour
    {
        public int startSadness;
        public int maxSadness = 100;
    
        public int width = 4;
        public int height = 4;

        public GameObject[] tiles;
        public GameObject startTile;
        public GameObject goalTile;

        public TileMap map;

        private int sadness;
        private Vector2Int currentPosition;
        private Vector2Int goalPosition;
    
        private void Start()
        {
            sadness = startSadness;
            
            currentPosition = new Vector2Int(0, 0);
            
            MakeGoals();
            BuildMap();
        }

        private void MakeGoals()
        {
            var goalX = width - 1;
            var goalY = Random.Range(0, height);
            goalPosition = new Vector2Int(goalX, goalY);
        }

        private void BuildMap()
        {
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    GameObject current;
                    if (x == 0 && y == 0)
                    {
                        current = Instantiate(startTile);
                    }
                    else if (x == goalPosition.x && y == goalPosition.y)
                    {
                        current = Instantiate(goalTile);
                    }
                    else
                    {
                        var tileNum = Random.Range(0, tiles.Length);
                        current = Instantiate(tiles[tileNum]);
                    }
                    Tile currentTile = current.GetComponent<Tile>();
                    currentTile.PosX = x;
                    currentTile.PosY = y;
                    current.transform.parent = map.gameObject.transform;
                }
            }
        }

        public void GainSadness(int amount)
        {
            sadness += amount;
            if (sadness > maxSadness)
            {
                // GameOver
            }
        }

        public void Move(Direction direction)
        {
            Debug.Log(direction);
            switch (direction)
            {
                case Direction.Left:
                    if (currentPosition.x > 0)
                    {
                        currentPosition.x--;
                        map.Slide(direction);
                    }
                    break;
                case Direction.Right:
                    if (currentPosition.x < width - 1)
                    {
                        currentPosition.x++;
                        map.Slide(direction);
                    }
                    break;
                case Direction.Up:
                    if (currentPosition.y < height - 1)
                    {
                        currentPosition.y++;
                        map.Slide(direction);
                    }
                    break;
                case Direction.Down:
                    if (currentPosition.y > 0)
                    {
                        currentPosition.y--;
                        map.Slide(direction);
                    }
                    break;
            }
        }
    }
}
