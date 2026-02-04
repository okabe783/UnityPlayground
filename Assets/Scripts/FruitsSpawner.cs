using UnityEngine;

public class FruitsSpawner : MonoBehaviour
{
    public GameObject[] FruitsPrefabs;
    public Transform SpawnPoint;
    
    private void Update()
    {
        if (!GameManager.Instance.CanSpawn())
        {
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
       Instantiate(FruitsPrefabs[Random.Range(0, 3)], SpawnPoint.position, Quaternion.identity);
       GameManager.Instance.StartFruitFall();
    }
}