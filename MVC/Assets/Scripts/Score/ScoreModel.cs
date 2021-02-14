using UniRx;

namespace Score
{
    public class ScoreModel : IScoreModel
    {
        private readonly CompositeDisposable _disposable;

        public ReactiveProperty<int> Score { get; }

        public ScoreModel(CompositeDisposable disposable)
        {
            _disposable = disposable;

            Score = new ReactiveProperty<int>().AddTo(_disposable);
        }
    }
}