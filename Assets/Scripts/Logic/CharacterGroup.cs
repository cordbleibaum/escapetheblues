using UnityEngine;

namespace Logic
{
	public class CharacterGroup : MonoBehaviour
	{
		public World World;
	
		public Character[] Characters;
		public Vector2Int GoalPosition;

		private void Start()
		{
			var goalX = World.Width - 1;
			var goalY = Random.Range(0, World.Height);
			GoalPosition = new Vector2Int(goalX, goalY);
		}
	}
}
