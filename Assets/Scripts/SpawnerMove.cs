using UnityEngine;

public class SpawnerMove : MonoBehaviour
{
    public float MoveSpeed = 5f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0; // 落ちないように
    }

    private void FixedUpdate()
    {
        if (!GameManager.Instance.CanMoveSpawner)
        {
            _rb.linearVelocity = Vector2.zero;
            return;
        }

        float input = Input.GetAxis("Horizontal");
        _rb.linearVelocity = new Vector2(input * MoveSpeed, 0f);
    }
}
