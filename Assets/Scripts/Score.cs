using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score;

    public void AddScore(int lastScore)
    {
        _score += lastScore;
        _scoreText.text = _score.ToString();
    }
}
