using UnityEngine;

// フルーツオブジェクトにアタッチして使います。
public class Fruits : MonoBehaviour
{
   // フルーツの種類をLevelで表しています
   public int Level;
   private bool _isMerged = false;

   // 同じフルーツがぶつかったときの処理
   private void OnCollisionEnter2D(Collision2D other)
   {
      if(_isMerged) return;
      Fruits fruits = other.gameObject.GetComponent<Fruits>();

      // ぶつかった相手が同じフルーツだったらより1つ上のレベルのものを生成します。
      if (fruits != null && fruits.Level == Level && fruits._isMerged == false)
      {
         _isMerged = true;
         fruits._isMerged = true;
         // ここで他のところで書いたメソッドを呼び出してます
         FruitsManager.Instance.MargeFruitsObject(this,fruits);
      }
   }
}
