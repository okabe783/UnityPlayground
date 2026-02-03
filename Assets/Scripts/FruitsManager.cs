using UnityEngine;

// フルーツオブジェクトを管理しています
public class FruitsManager : MonoBehaviour
{
    public static FruitsManager Instance;
    
    public GameObject[] FruitsPrefab;

    public void Awake()
    {
        Instance = this;
    }

    // 同じフルーツどうしがぶつかったときの処理をします
    public void MargeFruitsObject(Fruits a,Fruits b)
    {
        Vector3 pos = (a.transform.position + b.transform.position) / 2f;
        int nextLevel = a.Level + 1;
        
        Destroy(a.gameObject);
        Destroy(b.gameObject);

        if (nextLevel < FruitsPrefab.Length)
        {
            Instantiate(FruitsPrefab[nextLevel], pos, Quaternion.identity);
            // ToDo : スコアを増やす処理 マジックナンバー消す
            ScoreManager.Instance.AddScore(10);
        }
    }
}
