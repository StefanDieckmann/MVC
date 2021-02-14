using UniRx;

public class CharacterModel : ICharacterModel
{
    private readonly CompositeDisposable _disposable;
    private bool _isPressedOn;

    public CharacterModel(CompositeDisposable disposable)
    {
        _disposable = disposable;
    }
    
    public bool CharacterPressedOn
    {
        set => _isPressedOn = value;
    }
}