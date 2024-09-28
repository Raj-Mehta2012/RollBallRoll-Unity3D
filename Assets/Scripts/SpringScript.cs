using UnityEngine;

public class SpringCube : MonoBehaviour
{
    public float bounceForce = 500f;  // Force applied to the ball to make it bounce

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided is the ball (or any other specific object you want to bounce)
        if (collision.gameObject.CompareTag("Player"))  // Assuming the ball is tagged as "Player"
        {
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            if (ballRigidbody != null)
            {
                // Apply an upward force to the ball's Rigidbody to make it bounce
                ballRigidbody.AddForce(Vector3.up * bounceForce);
            }
        }
    }
}
