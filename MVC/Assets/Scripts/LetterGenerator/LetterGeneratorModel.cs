using System;
using UniRx;
using UnityEngine;
using Random = System.Random;

namespace LetterGenerator
{
    public class LetterGeneratorModel : ILetterGeneratorModel
    {
        public ReactiveProperty<string> LetterToFind { get; private set; }

        public LetterGeneratorModel(CompositeDisposable disposable)
        {
            LetterToFind = new ReactiveProperty<string>(string.Empty).AddTo(disposable);
            UpdateLetterToFind();
        }
        
        public void UpdateLetterToFind()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var index = new Random().Next(0, letters.Length);
            
            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length];

            LetterToFind.Value = value;
        }
    }
}