using System;
using UnityEngine;

namespace Presentation
{
    public class Tile : MonoBehaviour
    {

        public float slideX;
        public float slideY;
        public float slideSpeed;

        private float currentSlide;
        private Vector2 slideDirection;
        private bool destroyAfterSlide;
        
        public enum Direction
        {
            Left, Right, Up, Down
        }

        public void TransitionIn(Direction direction)
        {
            destroyAfterSlide = false;
            switch (direction)
            {
                case Direction.Left:
                    currentSlide = slideX;
                    slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Right:
                    currentSlide = slideX;
                    slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Up:
                    currentSlide = slideY;
                    slideDirection = new Vector2(0, -1);
                    break;
                case Direction.Down:
                    currentSlide = slideY;
                    slideDirection = new Vector2(0, 1);
                    break;
            }
        }
    
        public void TransitionOut(Direction direction)
        {
            destroyAfterSlide = true;
            switch (direction)
            {
                case Direction.Left:
                    currentSlide = slideX;
                    slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Right:
                    currentSlide = slideX;
                    slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Up:
                    currentSlide = slideY;
                    slideDirection = new Vector2(0, 1);
                    break;
                case Direction.Down:
                    currentSlide = slideY;
                    slideDirection = new Vector2(0, -1);
                    break;
            }
        }

        private void Update()
        {
            if (currentSlide > 0)
            {
                var slide = Math.Min(currentSlide, slideSpeed * Time.deltaTime);
                var slideVec = slide * slideDirection;

                gameObject.transform.Translate(slideVec);

            } 
            else if (destroyAfterSlide)
            {
                Destroy(gameObject);
            }
        }
    }
}
