using UnityEngine;

public class CharacterGroup : MonoBehaviour
{
	public World world;
	
	public Character[] characters;
	public Vector2Int goalPosition;

	private void Start()
	{
		int goalX = world.width - 1;
		int goalY = Random.Range(0, world.height);
		goalPosition = new Vector2Int(goalX, goalY);
	}
}
