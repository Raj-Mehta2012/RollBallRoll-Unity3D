using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public float moveSpeed = 10f;     
    public float brakeForce = 5f;     
    public float friction = 0.9f; 
    private Rigidbody rb;
    public Transform cameraTransform; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 movement = forward * moveVertical + right * moveHorizontal;

        // Apply force to the ball based on movement input
        if (movement.magnitude > 0)
        {
            rb.AddForce(movement * moveSpeed);
        }
        else
        {
            // Slow Dowm        
            rb.velocity = rb.velocity * friction;
        }

        // Apply brake
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = rb.velocity * (1 - brakeForce * Time.fixedDeltaTime);
        }
    }
}
