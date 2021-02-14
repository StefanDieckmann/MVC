using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScoreView : MonoBehaviour, IScoreView
    {
        [SerializeField] private Text _scoreText;

        public string ScoreText
        {
            set => _scoreText.text = value;
        }
    }
}