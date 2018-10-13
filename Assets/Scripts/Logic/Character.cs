using UnityEngine;

namespace Logic
{
    public class Character : MonoBehaviour
    {
        public CharacterGroup Group;
    
        public Vector2Int PersonalGoalPosition;

        private void Start()
        {
            var goalX = Random.Range(0, Group.World.Width);
            var goalY = Random.Range(0, Group.World.Height);
            if (goalY == 0 && goalX == 0)
            {
                while (goalX == 0)
                {
                    goalX = Random.Range(0, Group.World.Width);
                }
            }

            if (goalX == Group.World.Width - 1 && goalY == PersonalGoalPosition.y)
            {
                while (goalY == PersonalGoalPosition.y)
                {
                    goalY = Random.Range(0, Group.World.Height);
                }
            }
            PersonalGoalPosition = new Vector2Int(goalX, goalY);
        }
    }
}
