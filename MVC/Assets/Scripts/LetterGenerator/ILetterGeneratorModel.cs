using UniRx;

namespace LetterGenerator
{
    public interface ILetterGeneratorModel
    {
        ReactiveProperty<string> LetterToFind { get; }
        void UpdateLetterToFind();
    }
}