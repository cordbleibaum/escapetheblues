using System;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

namespace Presentation
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    
    public class Tile : MonoBehaviour
    {
        public int PosX;
        public int PosY;

        public float SpaceX;
        public float SpaceY;

        private void Start()
        {
            var spriteRenderer = GetComponent<SpriteRenderer>();

            transform.Translate(new Vector2(PosX*SpaceX, PosY*SpaceY));
        }
    }
}
