using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterGroup group;
    
    public Vector2Int personalGoalPosition;

    private void Start()
    {
        int goalX = Random.Range(0, group.world.width);
        int goalY = Random.Range(0, group.world.height);
        if (goalY == 0 && goalX == 0)
        {
            while (goalX == 0)
            {
                goalX = Random.Range(0, group.world.width);
            }
        }

        if (goalX == group.world.width - 1 && goalY == personalGoalPosition.y)
        {
            while (goalY == personalGoalPosition.y)
            {
                goalY = Random.Range(0, group.world.height);
            }
        }
        personalGoalPosition = new Vector2Int(goalX, goalY);
    }
}
