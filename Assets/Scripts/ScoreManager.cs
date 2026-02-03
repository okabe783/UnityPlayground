using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int Score;
    public Text ScoreText;

    private void Awake()
    {
        Instance = this;
    }

    // Scoreの加算処理をします
    public void AddScore(int score)
    {
        score += score;
        ScoreText.text = score.ToString();
    }
}