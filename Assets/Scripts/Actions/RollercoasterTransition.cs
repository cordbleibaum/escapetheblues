using Logic;
using Presentation;
using UnityEngine;

namespace Actions
{
    public class RollercoasterTransition : MonoBehaviour
    {
        private void OnEnable()
        {
            World.instance.Teleport(GhosttrainPosition.position.x, GhosttrainPosition.position.y);
        }
    }
}