using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace millionaire
{
    [RequireComponent(typeof(Button))]
    public class AnswerOption : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private AnswerType _type;
        
        public event Action<AnswerType> OnClicked;
        
        public AnswerType Type => _type;
        
        public void SetLabel(string label) => _label.text = label;

        public void ShowHint()
        {
            _button.image.color = Color.yellow;
        }

        public void ShowError()
        {
            _button.image.color = Color.red;
        }

        public void ShowCorrect()
        {
            _button.image.color = Color.green;
        }
        
        private void Start() => _button.onClick.AddListener(OnClick);

        private void OnClick() => OnClicked?.Invoke(_type);
    }
}