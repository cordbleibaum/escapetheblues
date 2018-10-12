using UnityEngine;

namespace Logic
{
    public class Character : MonoBehaviour
    {
        public CharacterGroup group;
    
        public Vector2Int personalGoalPosition;

        private void Start()
        {
            int goalX = Random.Range(0, group.World.Width);
            int goalY = Random.Range(0, group.World.Height);
            if (goalY == 0 && goalX == 0)
            {
                while (goalX == 0)
                {
                    goalX = Random.Range(0, group.World.Width);
                }
            }

            if (goalX == group.World.Width - 1 && goalY == personalGoalPosition.y)
            {
                while (goalY == personalGoalPosition.y)
                {
                    goalY = Random.Range(0, group.World.Height);
                }
            }
            personalGoalPosition = new Vector2Int(goalX, goalY);
        }
    }
}
