using Logic;
using UnityEngine;

public class TentAction : MonoBehaviour {
    private void OnEnable()
    {
        CharacterGroup.instance.timmy.sadness += 1;
        CharacterGroup.instance.uncle.sadness -= 10;
        CharacterGroup.instance.grandpa.sadness -= 10;
        CharacterGroup.instance.uncle.goalFulfilled = true;
    }
}
