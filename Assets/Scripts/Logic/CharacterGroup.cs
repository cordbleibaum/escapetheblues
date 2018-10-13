using Presentation;
using UnityEngine;

namespace Logic
{
	public class CharacterGroup : MonoBehaviour
	{
		public World World;
		
		public void Move(Direction direction)
		{
            World.Move(direction);
		}
	}
}
