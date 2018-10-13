using Logic;
using UnityEngine;

namespace Presentation
{
	public class Arrow : MonoBehaviour
	{
		public Direction direction;
		public World world;
	
		private void OnMouseDown()
		{
			world.Move(direction);
		}
	}
}
