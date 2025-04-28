using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 180f;
    public float thrustForce = 5f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.up * 0.7f, transform.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = transform.up * bulletSpeed;
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
