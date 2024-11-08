using NaughtyAttributes;
using UnityEngine;

namespace millionaire
{
    public class Mediator : MonoBehaviour
    {
        [SerializeField] private QuizScreen _quizScreen;
        
        [Button] public void ShowCorrectAnswer() => _quizScreen.ShowCorrectAnswer();
        [Button] public void ShowIncorrectAnswer() => _quizScreen.ShowIncorrectAnswer();
        [Button] public void ShowFiftyFifty() => _quizScreen.ShowFiftyFifty();
    }
}