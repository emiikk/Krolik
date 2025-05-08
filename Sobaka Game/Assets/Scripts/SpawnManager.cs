using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public Transform spawnPoint;
    

    private float startDelay = 1.0f;
//private float spawnInterval = 4.0f;

    void Start()
    {
        float spawnInterval = Random.Range(3.0f, 6.0f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, itemPrefabs.Length);  
        Instantiate(itemPrefabs[ballIndex], spawnPoint.position, itemPrefabs[ballIndex].transform.rotation);
    }
}
