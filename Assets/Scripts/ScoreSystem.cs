using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float score_multipler = 1f;

    public const string HighScoreKey = "HighScore";
    private float score;

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * score_multipler;
        scoreText.text = score.ToString("0");
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
