using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScoreButton : MonoBehaviour
{
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("Score");
        SceneManager.LoadScene("MainScene");
    }
}
