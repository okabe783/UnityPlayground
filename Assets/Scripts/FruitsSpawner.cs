using UnityEngine;
using UnityEngine.UI;

public class FruitsSpawner : MonoBehaviour
{
    public GameObject[] FruitsPrefabs;
    public Transform SpawnPoint;

    public Image NextImage;
    private int _currentIndex;
    private int _nextIndex;
    
    private void Start()
    {
        _currentIndex = Random.Range(0, FruitsPrefabs.Length);
        _nextIndex = Random.Range(0, FruitsPrefabs.Length);
    }
    
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
       Instantiate(FruitsPrefabs[_currentIndex], SpawnPoint.position, Quaternion.identity);
       GameManager.Instance.StartFruitFall();

       _currentIndex = _nextIndex;
       _nextIndex = Random.Range(0, FruitsPrefabs.Length);

       UpdateNextUI();
    }
    
    private void UpdateNextUI()
    {
        Fruits fruit = FruitsPrefabs[_nextIndex].GetComponent<Fruits>();
        NextImage.sprite = fruit.GetComponent<SpriteRenderer>().sprite;
    }
}