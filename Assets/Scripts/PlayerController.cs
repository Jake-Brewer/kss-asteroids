using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("Speed of rotation in degrees per second")] public float rotationSpeed = 180f;
    [Tooltip("Force applied when thrusting")] public float thrustForce = 5f;
    [Tooltip("Prefab for bullets")] public GameObject bulletPrefab;
    [Tooltip("Speed of fired bullets")] public float bulletSpeed = 10f;
    [Tooltip("Horizontal screen wrap boundary")] public float xBoundary = 9f;
    [Tooltip("Vertical screen wrap boundary")] public float yBoundary = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) Debug.LogError($"Rigidbody2D missing on {gameObject.name}");
    }

    void Update()
    {
        // Rotation
        float rotation = -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotation);

        // Thrust
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * thrustForce);
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        WrapScreen();
    }

    void Shoot()
    {
        if (bulletPrefab == null)
        {
            Debug.LogError("Bullet prefab not assigned");
            return;
        }
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.up * 0.7f, transform.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = transform.up * bulletSpeed;
    }

    // Deprecated: using WrapScreen in Update instead
    void OnBecameInvisible()
    {
        // Intentionally left blank
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
