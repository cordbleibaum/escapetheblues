using UnityEngine;

public class World : MonoBehaviour
{
    public int startSadness;
    public int maxSadness;
    
    public int width = 4;
    public int height = 4;

    public Tile[] tiles;
    public Vector2Int currentPosition;
    public Tile currentTile;

    private int sadness;
    
    private void Start()
    {
        sadness = startSadness;
    }
}
