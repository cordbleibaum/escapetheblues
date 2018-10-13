using Logic;
using TMPro;
using UnityEngine;

namespace Presentation
{
    public class Meter : MonoBehaviour
    {
        public TextMeshPro meter;

        private void Update()
        {
            meter.text = "Blues-Level: " + World.instance.GetSadness() + "%";
        }
    }
}