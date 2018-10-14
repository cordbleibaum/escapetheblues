using Logic;
using Presentation;
using UnityEngine;

namespace Actions
{
    public class GhosttrainTransition : MonoBehaviour
    {
        private void OnEnable()
        {
            World.instance.Teleport(RollercoasterPosition.position.x, RollercoasterPosition.position.y);
        }
    }
}