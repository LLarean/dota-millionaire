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
        private int _currentQuestionIndex;
        
        private void Start()
        {
            _quizScreen.OnHintSelected += OnHintSelected;
            _quizScreen.OnAnswerSelected += OnAnswerSelected;
            ShowNextQuestion();
        }

        private void OnAnswerSelected(AnswerType selectedAnswer)
        {
            if (selectedAnswer == _currentQuestion.RightAnswer)
            {
                _quizScreen.ShowCorrect();
            }
            else
            {
                _quizScreen.ShowError();
            }

            // ShowNextQuestion();
        }

        private void OnHintSelected(HintType hintType)
        {
            if (hintType == HintType.FiftyFifty)
            {
                _quizScreen.ShowFiftyFifty(_currentQuestion.RightAnswer);
            }
            else
            {
                _quizScreen.ShowHint(_currentQuestion.RightAnswer);
            }
        }

        private void ShowNextQuestion()
        {
            _currentQuestion = _easyQuestions.Questions[Random.Range(0, _easyQuestions.Questions.Count)];
            _quizScreen.ShowQuestionData(_currentQuestion);
        }

        private void GetQuestion()
        {
            _currentQuestion = _currentQuestionIndex switch
            {
                <= 5 => _easyQuestions.Questions[Random.Range(0, _easyQuestions.Questions.Count)],
                <= 10 => _middleQuestions.Questions[Random.Range(0, _middleQuestions.Questions.Count)],
                _ => _hardQuestions.Questions[Random.Range(0, _hardQuestions.Questions.Count)]
            };
        }
    }
}