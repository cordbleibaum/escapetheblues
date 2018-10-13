using System;
using UnityEngine;

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

        private float _currentSlide;
        private Vector2 _slideDirection;
        private bool _destroyAfterSlide;

        public void TransitionIn(Direction direction)
        {
            _destroyAfterSlide = false;
            switch (direction)
            {
                case Direction.Left:
                    _currentSlide = SlideX;
                    _slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Right:
                    _currentSlide = SlideX;
                    _slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Up:
                    _currentSlide = SlideY;
                    _slideDirection = new Vector2(0, -1);
                    break;
                case Direction.Down:
                    _currentSlide = SlideY;
                    _slideDirection = new Vector2(0, 1);
                    break;
            }
        }
    
        public void TransitionOut(Direction direction)
        {
            _destroyAfterSlide = true;
            switch (direction)
            {
                case Direction.Left:
                    _currentSlide = SlideX;
                    _slideDirection = new Vector2(-1, 0);
                    break;
                case Direction.Right:
                    _currentSlide = SlideX;
                    _slideDirection = new Vector2(1, 0);
                    break;
                case Direction.Up:
                    _currentSlide = SlideY;
                    _slideDirection = new Vector2(0, 1);
                    break;
                case Direction.Down:
                    _currentSlide = SlideY;
                    _slideDirection = new Vector2(0, -1);
                    break;
            }
        }

        private void Update()
        {
            if (_currentSlide > 0)
            {
                var slide = Math.Min(_currentSlide, SlideSpeed * Time.deltaTime);
                var slideVec = slide * _slideDirection;

                gameObject.transform.Translate(slideVec);

            } 
            else if (_destroyAfterSlide)
            {
                Destroy(gameObject);
            }
        }
    }
}
