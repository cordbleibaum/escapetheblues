using Presentation;
using UnityEngine;

namespace Logic
{
	public class CharacterGroup : MonoBehaviour
	{
		public static CharacterGroup instance;

		private void Start()
		{
			instance = this;
			timmy.sadness = 0;
			sister.sadness = 0;
			uncle.sadness = 0;
			grandpa.sadness = 0;
		}

		public Character timmy;
		public Character uncle;
		public Character sister;
		public Character grandpa;
	}
}
