using LetterGenerator;
using Score;
using UniRx;
using UniRx.Triggers;

namespace Character
{
    public class CharacterController
    {
        private readonly ICharacterView _characterView;
        private readonly ICharacterModel _characterModel;
        private readonly IScoreModel _scoreModel;
        private readonly CompositeDisposable _disposable;

        public CharacterController(ICharacterView characterView, ICharacterModel characterModel, IScoreModel scoreModel,
            ILetterGeneratorModel letterGeneratorModel, CompositeDisposable disposable)
        {
            _characterView = characterView;
            _characterModel = characterModel;
            _scoreModel = scoreModel;
            _disposable = disposable;

            _characterView.CharacterButton.OnClickAsObservable().Subscribe(_ =>
            {
                _characterModel.CharacterPressedOn = !_characterModel.CharacterPressedOn;
                _characterView.CharacterButtonText = $"Is {_characterModel.CharacterPressedOn} {letterGeneratorModel.LetterToFind.Value}";
                _scoreModel.Score.Value++;
            }).AddTo(_disposable);
            
            _characterView.CharacterButton.OnCollisionEnter2DAsObservable().Subscribe(_ =>
            {
                // Do something for a collision enter
            }).AddTo(_disposable);
            
            _characterView.CharacterButton.OnMouseDragAsObservable().Subscribe(_ =>
            {
                // Do something for a mouse drag event
            }).AddTo(_disposable);
        }
    }
}