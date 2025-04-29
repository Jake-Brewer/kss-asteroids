using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Tooltip("Number of lives at start")] public int startingLives = 3;

    private int score;
    private int lives;

    public GameObject playerPrefab;
    public GameObject asteroidPrefab;
    public GameObject bulletPrefab;
    public int initialAsteroidCount = 5;

    void Awake()
    {
        // Singleton setup
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Validate prefabs
        if (playerPrefab == null) Debug.LogError("GameManager: playerPrefab not assigned");
        if (asteroidPrefab == null) Debug.LogError("GameManager: asteroidPrefab not assigned");
        if (bulletPrefab == null) Debug.LogError("GameManager: bulletPrefab not assigned");
    }

    void Start()
    {
        lives = startingLives;
        // Spawn player
        Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        // Spawn asteroids
        for (int i = 0; i < initialAsteroidCount; i++)
        {
            Vector2 spawnPos = Random.insideUnitCircle.normalized * Random.Range(5f, 8f);
            Instantiate(asteroidPrefab, new Vector3(spawnPos.x, spawnPos.y, 0), Quaternion.identity);
        }
    }

    /// <summary>
    /// Increase the player's score.
    /// </summary>
    public void AddScore(int amount)
    {
        score += amount;
        // TODO: update score UI if bound
    }

    /// <summary>
    /// Called when the player is hit by an asteroid.
    /// </summary>
    public void PlayerHit()
    {
        lives--;
        if (lives <= 0)
        {
            GameOver();
        }
        else
        {
            // Respawn player
            Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        }
    }

    private void GameOver()
    {
        Debug.Log($"Game Over! Final Score: {score}");
        // TODO: trigger game over UI and restart logic
    }
}
