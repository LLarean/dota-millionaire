using System;
using System.Threading.Tasks;
using UnityEngine;

namespace millionaire
{
    public class QuizPresenter
    {
        private readonly QuizModel _model;
        private readonly QuizView _view;

        public QuizPresenter(QuizModel model, QuizView view)
        {
            _model = model;
            _view = view;

            _view.OnHintSelected += SelectHint;
            _view.OnAnswerSelected += SelectAnswer;
        }

        public void Launch()
        {
            _view.ShowQuestion(_model.Questions[_model._currentQuestionIndex]);
        }

        private void SelectHint(HintType selectedHint)
        {
            throw new NotImplementedException();
        }

        private void SelectAnswer(AnswerType selectedAnswer)
        {
            if (selectedAnswer == _model.Questions[_model._currentQuestionIndex].CorrectAnswer)
            {
                Debug.Log("Correct");
                _ = ShowQuestionDelay();
            }
            else
            {
                Debug.Log("Wrong");
            }
        }
        
        private async Task ShowQuestionDelay()
        {
            await Task.Delay(2000);
            _model._currentQuestionIndex++;
            _view.ShowQuestion(_model.Questions[_model._currentQuestionIndex]);
        }
    }
}