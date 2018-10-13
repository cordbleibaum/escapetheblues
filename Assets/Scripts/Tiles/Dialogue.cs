using Logic;
using TMPro;
using UnityEngine;

namespace Presentation
{
    public class Dialogue: MonoBehaviour
    {
        [System.Serializable]
        public struct DialogueLine
        {
            public string text;
            public int next;
            public bool isLast;
            public DialogueOption[] options;
        }

        [System.Serializable]
        public struct DialogueOption
        {
            public string text;
            public int next;
        }

        public int start;
        public DialogueLine[] lines;

        public TextMeshProUGUI text;

        private DialogueLine current;
        
        private void OnEnable()
        {
            current = lines[0];
            text.text = current.text;
            if (!current.isLast)
            {
                World.instance.canSlide = false;
            }
            else
            {
                World.instance.canSlide = true; 
            }
        }

        public void Next()
        {
            if (current.options.Length == 0)
            {
                current = lines[current.next];
                text.text = current.text;
                if (!current.isLast)
                {
                    World.instance.canSlide = false;
                }
                else
                {
                    World.instance.canSlide = true; 
                } 
            }
        }
    }
}