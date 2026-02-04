using UnityEngine;

// フルーツオブジェクトを管理しています
public class FruitsManager : MonoBehaviour
{
    public static FruitsManager Instance;
    
    public GameObject[] FruitsLabel;

    private void Awake()
    {
        Instance = this;
    }

    // 同じフルーツどうしがぶつかったときの処理をします
    public bool MargeFruitsObject(Fruits a,Fruits b)
    {
        int nextLevel = a.Level + 1;
        
        // 一番大きいフルーツだったらくっつけない
        if (nextLevel >= FruitsLabel.Length)
        {
            return false;
        }
        
        Vector3 pos = (a.transform.position + b.transform.position) / 2f;
        
        Destroy(a.gameObject);
        Destroy(b.gameObject);

        GameObject fruits = Instantiate(FruitsLabel[nextLevel].gameObject, pos, Quaternion.identity);
        // ここでスコアを加算します
        ScoreManager.Instance.AddScore(fruits.GetComponent<Fruits>().Score);
        
        return true;
    }
}
