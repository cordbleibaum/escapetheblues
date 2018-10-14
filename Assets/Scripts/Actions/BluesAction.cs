using Logic;
using UnityEngine;

namespace Actions
{
    public class BluesAction : MonoBehaviour
    {
        private void OnEnable()
        {
            CharacterGroup.instance.timmy.sadness += 10;
            CharacterGroup.instance.sister.sadness += 10;
            CharacterGroup.instance.grandpa.sadness += 10;
            CharacterGroup.instance.uncle.sadness += 10;
        }
    }
}