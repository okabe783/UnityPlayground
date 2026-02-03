using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool IsGameOver = false;

    private void Awake()
    {
        Instance = this;
    }

    // ゲーム終了のフラグをたてる
    public void GameOver()
    {
        IsGameOver = true;
    }
}