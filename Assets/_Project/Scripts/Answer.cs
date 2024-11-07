using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace millionaire
{
    [RequireComponent(typeof(Button))]
    public class Answer : MonoBehaviour
    {
        [SerializeField] private AnswerType _type;
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private Button _button;
        
        public event Action<AnswerType> OnClicked;
        
        public AnswerType Type => _type;

        public void SetLabel(string label) => _label.text = label;
        
        private void Start() => _button.onClick.AddListener(Click);

        private void OnDestroy() => _button.onClick.RemoveAllListeners();

        private void Click() => OnClicked?.Invoke(_type);
    }
}