using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Asteroid : MonoBehaviour
{
    public float speed = 2f;
    public int size = 3; // 3 = large, 2 = medium, 1 = small
    public GameObject asteroidPrefab;
    [Tooltip("Horizontal screen wrap boundary")] public float xBoundary = 9f;
    [Tooltip("Vertical screen wrap boundary")] public float yBoundary = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) Debug.LogError($"Rigidbody2D missing on {gameObject.name}");
    }

    void Start()
    {
        rb.velocity = Random.insideUnitCircle.normalized * speed;
        transform.Rotate(0, 0, Random.Range(0f, 360f));
    }

    void Update()
    {
        WrapScreen();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            HandleHitByBullet(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            HandlePlayerCollision(collision.gameObject);
        }
    }

    private void HandleHitByBullet(GameObject bullet)
    {
        if (size > 1 && asteroidPrefab != null)
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject newAsteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
                var a = newAsteroid.GetComponent<Asteroid>();
                if (a != null)
                {
                    a.size = size - 1;
                    newAsteroid.transform.localScale = transform.localScale * 0.5f;
                }
            }
        }
        Destroy(gameObject);
        Destroy(bullet);
        GameManager.Instance?.AddScore(CalculateScore());
    }

    private void HandlePlayerCollision(GameObject player)
    {
        GameManager.Instance?.PlayerHit();
    }

    private int CalculateScore()
    {
        switch (size)
        {
            case 3: return 20;
            case 2: return 50;
            case 1: return 100;
            default: return 0;
        }
    }

    void OnBecameInvisible()
    {
        // Deprecated; screen wrap in Update
    }

    private void WrapScreen()
    {
        Vector3 newPos = transform.position;
        if (newPos.x > xBoundary) newPos.x = -xBoundary;
        else if (newPos.x < -xBoundary) newPos.x = xBoundary;
        if (newPos.y > yBoundary) newPos.y = -yBoundary;
        else if (newPos.y < -yBoundary) newPos.y = yBoundary;
        transform.position = newPos;
    }
}
