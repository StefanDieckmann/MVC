using UniRx;

namespace Score
{
    public class ScoreController
    {
        private readonly IScoreView _scoreView;
        private readonly IScoreModel _scoreModel;
        private readonly CompositeDisposable _disposable;

        public ScoreController(IScoreView scoreView, IScoreModel scoreModel, CompositeDisposable disposable)
        {
            _scoreView = scoreView;
            _scoreModel = scoreModel;
            _disposable = disposable;

            _scoreModel.Score.Subscribe(score => _scoreView.ScoreText = $"Score {score}").AddTo(_disposable);
        }
    }
}