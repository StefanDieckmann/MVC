using UniRx;
using UnityEngine;

public class CharacterController
{
    private readonly ICharacterView _characterView;
    private readonly ICharacterModel _characterModel;
    private readonly CompositeDisposable  _disposable;

    public CharacterController(ICharacterView characterView, ICharacterModel characterModel, CompositeDisposable disposable)
    {
        _characterView = characterView;
        _characterModel = characterModel;
        _disposable = disposable;
        
        _characterView.CharacterButton.OnClickAsObservable().Subscribe(_ =>
        {
            Debug.Log("Pressed");
        }).AddTo(_disposable);
    }
}