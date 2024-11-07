using UnityEngine;

namespace millionaire
{
    public class GameLogic : MonoBehaviour
    {
        [SerializeField] private QuizScreen _quizScreen;
        [Space]
        [SerializeField] private QuestionsData _easyQuestions;
        [SerializeField] private QuestionsData _middleQuestions;
        [SerializeField] private QuestionsData _hardQuestions;

        private QuestionData _currentQuestion;
        
        private void Start()
        {
            _currentQuestion = _easyQuestions.Questions[0];
            _quizScreen.ShowQuestions(_currentQuestion);
            
            _quizScreen.OnAnswerSelected += OnAnswerSelected;
            
        }

        private void OnAnswerSelected(AnswerType selectedAnswer)
        {
            if (selectedAnswer == _currentQuestion.RightAnswer)
            {
                Debug.Log("Correct!");
            }
            else
            {
                Debug.Log("Wrong!");
            }
        }
    }
}