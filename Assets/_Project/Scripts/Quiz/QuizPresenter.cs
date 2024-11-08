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
            throw new System.NotImplementedException();
        }

        private void SelectAnswer(AnswerType selectedAnswer)
        {
            throw new System.NotImplementedException();
        }
    }
}