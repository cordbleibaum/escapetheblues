using Logic;
using UnityEngine;

public class SoothsayerAction : MonoBehaviour {
    private void OnEnable()
    {
        CharacterGroup.instance.uncle.sadness += 20;
        CharacterGroup.instance.uncle.goalFulfilled = true;
        CharacterGroup.instance.sister.sadness -= 10;
    }
}
