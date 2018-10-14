using Logic;
using UnityEngine;

namespace Actions
{
    public class GhosttrainArrival : MonoBehaviour
    {
        private void OnEnable()
        {
            CharacterGroup.instance.sister.goalFulfilled = true;
            CharacterGroup.instance.sister.goalCheck.SetActive(true);
            CharacterGroup.instance.sister.sadness = 0;
            CharacterGroup.instance.timmy.sadness -= 10;
            CharacterGroup.instance.uncle.sadness += 10;
            CharacterGroup.instance.grandpa.sadness += 5;
        }
    }
}