using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx.Triggers;

public class CharacterView : MonoBehaviour, ICharacterView
{
    [SerializeField] private Button _characterButton;
    
    public Button CharacterButton => _characterButton;
}