using UnityEngine.UI;

namespace Character
{
    public interface ICharacterView
    {
        Button CharacterButton { get; }
        string CharacterButtonText { set; }
    }
}