using System.Linq;
using Presentation;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Logic
{
    public class World : MonoBehaviour
    {
        public static World instance;
        
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

        private Tile[][] mapTiles;

        private Tile currentTile;
    
        private void Start()
        {
            Random.InitState(Time.renderedFrameCount);
            
            sadness = startSadness;
            
            currentPosition = new Vector2Int(0, 0);
            
            MakeGoals();
            BuildMap();
            
            currentTile = mapTiles[currentPosition.x][currentPosition.y];

            instance = this;
        }

        private void MakeGoals()
        {
            var goalX = width - 1;
            var goalY = Random.Range(0, height);
            goalPosition = new Vector2Int(goalX, goalY);
        }

        private void BuildMap()
        {
            mapTiles = new Tile[width][];
            for (var x = 0; x < width; x++)
            {
                mapTiles[x] = new Tile[height];
                for (var y = 0; y < height; y++)
                {
                    GameObject tileObject;
                    if (x == 0 && y == 0)
                    {
                        tileObject = Instantiate(startTile);
                    }
                    else if (x == goalPosition.x && y == goalPosition.y)
                    {
                        tileObject = Instantiate(goalTile);
                    }
                    else
                    {
                        var tileNum = Random.Range(0, tiles.Length);
                        tileObject = Instantiate(tiles[tileNum]);
                    }
                    var tileComponent = tileObject.GetComponent<Tile>();
                    if (tileComponent.isLimited)
                    {
                        tiles = tiles.Where(t => t.GetComponent<Tile>().id != tileComponent.id).ToArray();
                    }
                    mapTiles[x][y] = tileComponent;
                    tileComponent.PosX = x;
                    tileComponent.PosY = y;
                    tileObject.transform.parent = map.gameObject.transform;
                }
            }
        }

        public int GetSadness()
        {
            return sadness;
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
            
            if (!map.CanSlide()) return;

            var switchTile = false;
            
            switch (direction)
            {
                case Direction.Left:
                    if (currentPosition.x > 0)
                    {
                        currentPosition.x--;
                        switchTile = true;
                    }
                    break;
                case Direction.Right:
                    if (currentPosition.x < width - 1)
                    {
                        currentPosition.x++;
                        switchTile = true;
                    }
                    break;
                case Direction.Up:
                    if (currentPosition.y < height - 1)
                    {
                        currentPosition.y++;
                        switchTile = true;
                    }
                    break;
                case Direction.Down:
                    if (currentPosition.y > 0)
                    {
                        currentPosition.y--;
                        switchTile = true;
                    }
                    break;
            }

            if (switchTile)
            {
                map.Slide(direction);
                currentTile.OnLeave();
                currentTile = mapTiles[currentPosition.x][currentPosition.y];
                currentTile.OnGoto();
            }
        }
    }
}
