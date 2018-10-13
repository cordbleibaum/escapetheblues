using UnityEngine;

namespace Presentation
{
    public class TileMap : MonoBehaviour
    {
        public float slideX;
        public float slideY;
        public float slideSpeed;
        
        private float currentSlide;
        private Vector2 slideDirection;

        public bool CanSlide()
        {
            return !(currentSlide > 0.0001f);
        }
        
        public void Slide(Direction direction)
        {
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

        private void Update()
        {
            if (currentSlide > 0.0001f)
            {
                var slide = Mathf.Min(currentSlide, slideSpeed * Time.deltaTime);
                currentSlide -= slide;
                
                var slideVec = slide * slideDirection;

                gameObject.transform.Translate(slideVec);

            }
        }
    }
}