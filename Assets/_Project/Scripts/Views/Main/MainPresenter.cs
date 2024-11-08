namespace millionaire
{
    public class MainPresenter
    {
        private readonly MainModel _model;
        private readonly MainView _view;

        public MainPresenter(MainModel model, MainView view)
        {
            _model = model;
            _view = view;
        }
    }
}
