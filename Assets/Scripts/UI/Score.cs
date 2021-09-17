using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private float _score;

    private void Start()
    {
        _score = PlayerPrefs.GetFloat("Score");
        _scoreText.text = BigNumberConverter.ConvertNumber(_score);
    }

    public void AddScore(int lastScore)
    {
        _score += lastScore;
        _scoreText.text = BigNumberConverter.ConvertNumber(_score);
    }

    public float GetScore()
    {
        return _score;
    }
}
