using UnityEngine;

// フルーツオブジェクトにアタッチして使います。
public class Fruits : MonoBehaviour
{
    // フルーツの種類をLevelで表しています
    public int Level;

    // フルーツが合体したときに加算されるスコア量
    public int Score;
    private bool _isMerged = false;
    private Rigidbody2D _rb;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // 同じフルーツがぶつかったときの処理
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_isMerged) return;

        Fruits fruits = other.gameObject.GetComponent<Fruits>();
        // ぶつかった相手が同じフルーツだったらより1つ上のレベルのものを生成します。
        if (fruits == null || fruits.Level != Level || fruits._isMerged)
        {
            return;
        }
        
        if (GetInstanceID() > fruits.GetInstanceID())
        {
            return;
        }

        bool merged = FruitsManager.Instance.MargeFruitsObject(this, fruits);

        // くっつけることのできるフルーツ同士がぶつかったときに合体したフラグをオンにしています
        if (merged)
        {
            _isMerged = true;
            fruits._isMerged = true;
        }
    }
}