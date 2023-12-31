using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);
        highScoreText.text = $"High Score: {highScore}";
    }

    public void PlayGame()
    {
        // Load the next scene in the build order
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
