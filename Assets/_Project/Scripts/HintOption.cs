using System;
using UnityEngine;
using UnityEngine.UI;

namespace millionaire
{
    [RequireComponent(typeof(Button))]
    public class HintOption : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private HintType _type;
        
        public event Action<HintType> OnClicked;
        
        public HintType Type;

        public void Disable() => _button.interactable = false;

        private void Start() => _button.onClick.AddListener(OnClick);

        private void OnClick() => OnClicked?.Invoke(_type);
    }
}