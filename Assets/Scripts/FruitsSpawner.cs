using UnityEngine;

public class FruitsSpawner : MonoBehaviour
{
    public GameObject[] FruitsPrefabs;
    public Transform SpawnPoint;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.IsGameOver == false)
        {
            // 数字を変えないといけない
            int random = Random.Range(0, 3);
            Instantiate(FruitsPrefabs[random],SpawnPoint.position,Quaternion.identity);
        }
    }
}
