using Logic;
using UnityEngine;

namespace Presentation
{
	public class Arrow : MonoBehaviour
	{
		public Direction direction;
		private CharacterGroup group;
	
		private void OnMouseDown()
		{
			group.Move(direction);
		}
	}
}
