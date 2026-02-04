using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool IsGameOver = false;
    // スポナーを動かすことができるか
    public bool CanMoveSpawner = true;
    private bool _canSpawn = true;
    
    private void Awake()
    {
        Instance = this;
    }

    public bool CanSpawn()
    {
        return _canSpawn;
    }

    // フルーツを落とした瞬間に呼ぶ
    public void StartFruitFall()
    {
        _canSpawn = false;
        StartCoroutine(SpawnWaitCoroutine());
    }

    private IEnumerator SpawnWaitCoroutine()
    {
        yield return new WaitForSeconds(3f);
        _canSpawn = true;
    }

    // ゲーム終了のフラグをたてる
    public void GameOver()
    {
        IsGameOver = true;
    }
}