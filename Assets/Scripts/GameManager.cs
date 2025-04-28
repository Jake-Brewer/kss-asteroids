using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject asteroidPrefab;
    public GameObject bulletPrefab;
    public int initialAsteroidCount = 5;

    void Start()
    {
        // Spawn player
        Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        // Spawn asteroids
        for (int i = 0; i < initialAsteroidCount; i++)
        {
            Vector2 spawnPos = Random.insideUnitCircle.normalized * Random.Range(5f, 8f);
            Instantiate(asteroidPrefab, new Vector3(spawnPos.x, spawnPos.y, 0), Quaternion.identity);
        }
    }
}
