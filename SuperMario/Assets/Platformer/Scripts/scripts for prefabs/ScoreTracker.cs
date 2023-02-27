using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public static int score = 0000;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Mario \n" + score;
    }
}