﻿using System;
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
        
        private void Start() => _button.onClick.AddListener(OnClick);

        private void OnClick() => OnClicked?.Invoke(_type);
    }
}