using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Presentation
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    
    public class Tile : MonoBehaviour
    {

        public float SlideX;
        public float SlideY;
        public float SlideSpeed;

        private float currentSlide;
        private Vector2 slideDirection;
        private bool destroyAfterSlide;

        public void TransitionIn(Direction direction)
        {
            destroyAfterSlide = false;
            switch (direction)
            {
                case Direction.Left:
                    currentSlide = SlideX;
                    slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Right:
                    currentSlide = SlideX;
                    slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Up:
                    currentSlide = SlideY;
                    slideDirection = new Vector2(0, -1);
                    break;
                case Direction.Down:
                    currentSlide = SlideY;
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
                    currentSlide = SlideX;
                    slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Right:
                    currentSlide = SlideX;
                    slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Up:
                    currentSlide = SlideY;
                    slideDirection = new Vector2(0, 1);
                    break;
                case Direction.Down:
                    currentSlide = SlideY;
                    slideDirection = new Vector2(0, -1);
                    break;
            }
        }

        private void Update()
        {
            if (currentSlide > 0)
            {
                var slide = Math.Min(currentSlide, SlideSpeed * Time.deltaTime);
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
