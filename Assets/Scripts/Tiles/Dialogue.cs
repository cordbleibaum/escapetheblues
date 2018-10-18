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
            public GameObject nextAction;
            public GameObject afterAction;
        }

        [System.Serializable]
        public struct DialogueOption
        {
            public string text;
            public int next;
        }

        public int start;
        public DialogueLine[] lines;
        public GameObject[] optionButtons;
        
        public TextMeshProUGUI text;

        public GameObject nextAction;

        private DialogueLine current;

        private void UpdateText()
        {        
            text.text = current.text;
            if (!current.isLast)
            {
                World.instance.canSlide = false;
            }
            else
            {
                GameObject canvas = (transform.Find("Canvas")).gameObject;
                if (canvas) canvas.SetActive(false);

                World.instance.canSlide = true;
                if (nextAction) nextAction.SetActive(true);
                if (current.nextAction) current.nextAction.SetActive(true);
            }

            if (optionButtons.Length > 0)
            {
                optionButtons[0].SetActive(current.options.Length > 0);
                optionButtons[1].SetActive(current.options.Length > 1);
                optionButtons[2].SetActive(current.options.Length > 2);
                optionButtons[3].SetActive(current.options.Length > 3);
            }

            if (current.options.Length > 0)
            {
                optionButtons[0].GetComponent<TextMeshProUGUI>().text = current.options[0].text;
            }
            
            if (current.options.Length > 1)
            {
                optionButtons[1].GetComponent<TextMeshProUGUI>().text = current.options[1].text;
            }
            
            if (current.options.Length > 2)
            {
                optionButtons[2].GetComponent<TextMeshProUGUI>().text = current.options[2].text;
            }
            
            if (current.options.Length > 3)
            {
                optionButtons[3].GetComponent<TextMeshProUGUI>().text = current.options[3].text;
            }
        }
        
        private void OnEnable()
        {
            current = lines[0];
            UpdateText();
        }

        public void Next()
        {
            if (current.options.Length == 0)
            {
                if (current.afterAction) current.afterAction.SetActive(true);
                current = lines[current.next];
                UpdateText();
            }
        }

        public void UseOption(int number)
        {
            if (number < current.options.Length)
            {
                if (current.afterAction) current.afterAction.SetActive(true);
                current = lines[current.options[number].next];
                UpdateText();
            }
        }
    }
}