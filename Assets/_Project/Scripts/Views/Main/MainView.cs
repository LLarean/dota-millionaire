using System;
using UnityEngine;
using UnityEngine.UI;

namespace millionaire
{
    public class MainView : MonoBehaviour
    {
        [SerializeField] private Button _start;

        public event Action OnStartClicked;
        
        private void Start()
        {
            _start.onClick.AddListener(StartGame);
        }

        private void StartGame() => OnStartClicked?.Invoke();
    }

    public class View : MonoBehaviour
    {
        public void Show()
        {
            
        }

        public void Hide()
        {
            
        }
    }
}