using Presentation;
using UnityEngine;

namespace Logic
{
	public class CharacterGroup : MonoBehaviour
	{
		public CharacterGroup instance;

		private void Start()
		{
			instance = this.instance;
		}

		public Character timmy;
		public Character uncle;
		public Character sister;
		public Character grandpa;
	}
}
