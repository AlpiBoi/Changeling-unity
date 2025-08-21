using UnityEngine;

public class spawnWave : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject spawnArea;
    [SerializeField] private int spawnCount = 5;

     void Start()
    {
        BoxCollider2D spawnCollider = spawnArea.GetComponent<BoxCollider2D>();
        Vector2 size = spawnCollider.size;
        Vector2 halfSize = spawnCollider.size/2f ;

        for (int i = 0; i < spawnCount; i++)
        {

            Vector3 randomPosition = new Vector3(Random.Range(-halfSize.x, halfSize.x), Random.Range(2, size.y), 0f);

            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
        }
    }
}
