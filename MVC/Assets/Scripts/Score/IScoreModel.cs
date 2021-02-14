using UniRx;

namespace Score
{
    public interface IScoreModel
    {
        ReactiveProperty<int> Score { get; }
    }
}