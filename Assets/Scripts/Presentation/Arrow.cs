using Logic;
using UnityEngine;

namespace Presentation
{
	public class Arrow : MonoBehaviour
	{
		public Direction Direction;
		public CharacterGroup Group;
	
		private void OnMouseDown()
		{
			Group.Move(Direction);
		}
	}
}
