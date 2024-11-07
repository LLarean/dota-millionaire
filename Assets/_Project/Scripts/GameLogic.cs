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
            _quizScreen.OnAnswerSelected += OnAnswerSelected;
            ShowNextQuestion();
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

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            _currentQuestion = _easyQuestions.Questions[Random.Range(0, _easyQuestions.Questions.Count)];
            _quizScreen.ShowQuestionData(_currentQuestion);
        }
    }
}