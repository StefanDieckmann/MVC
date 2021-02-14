using UniRx;

namespace Character
{
    public class CharacterModel : ICharacterModel
    {
        private readonly CompositeDisposable _disposable;

        public CharacterModel(CompositeDisposable disposable)
        {
            _disposable = disposable;
        }

        public bool CharacterPressedOn { get; set; }
    }
}