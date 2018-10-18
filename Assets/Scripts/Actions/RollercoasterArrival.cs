using Logic;
using UnityEngine;

namespace Actions
{
    public class RollercoasterArrival : MonoBehaviour
    {
        private void OnEnable()
        {
            CharacterGroup.instance.timmy.goalFulfilled = true;
            CharacterGroup.instance.timmy.goalCheck.SetActive(true);
            CharacterGroup.instance.sister.sadness = 0;
            CharacterGroup.instance.timmy.sadness -= 10;
            CharacterGroup.instance.uncle.sadness += 10;
            CharacterGroup.instance.grandpa.sadness += 5;
        }
    }
}