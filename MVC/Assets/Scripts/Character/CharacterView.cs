using UnityEngine;
using UnityEngine.UI;

namespace Character
{
    public class CharacterView : MonoBehaviour, ICharacterView
    {
        [SerializeField] private Button _characterButton;
        [SerializeField] private Text _characterButtonText;

        public Button CharacterButton => _characterButton;

        public string CharacterButtonText
        {
            set => _characterButtonText.text = value;
        }
    }
}