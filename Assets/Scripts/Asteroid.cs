using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 2f;
    public int size = 3; // 3 = large, 2 = medium, 1 = small
    public GameObject asteroidPrefab;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Random.insideUnitCircle.normalized * speed;
        transform.Rotate(0, 0, Random.Range(0f, 360f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (size > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject newAsteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
                    newAsteroid.GetComponent<Asteroid>().size = size - 1;
                    newAsteroid.transform.localScale = transform.localScale * 0.5f;
                }
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    void OnBecameInvisible()
    {
        // Screen wrap
        Vector3 newPos = transform.position;
        if (newPos.x > 9) newPos.x = -9;
        else if (newPos.x < -9) newPos.x = 9;
        if (newPos.y > 5) newPos.y = -5;
        else if (newPos.y < -5) newPos.y = 5;
        transform.position = newPos;
    }
}
