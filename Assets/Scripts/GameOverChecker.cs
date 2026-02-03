using UnityEngine;

public class GameOverChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Fruits>())
        {
            GameManager.Instance.GameOver();
        }
    }
}