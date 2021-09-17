using UnityEngine;

public class ScoreData : MonoBehaviour
{
    [SerializeField] private Score _score;

    public void OnClickSave()
    {
        PlayerPrefs.SetFloat("Score", _score.GetScore());
    }
}
