using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpForce = 15f;
    private Rigidbody2D rb;
    private Collider2D playerCollider;
    private const float screenRadius = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Move left and right
        float moveInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * moveInput * moveSpeed * Time.deltaTime;

        // Wrap around screen
        if (transform.position.x > screenRadius)
            transform.position = new Vector3(-screenRadius, transform.position.y, transform.position.z);
        else if (transform.position.x < -screenRadius)
            transform.position = new Vector3(screenRadius, transform.position.y, transform.position.z);
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        // Only land if the player is falling (allows player to pass through platforms on the way up)
        if (collision.CompareTag("Platform") && rb.linearVelocity.y <= 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

}