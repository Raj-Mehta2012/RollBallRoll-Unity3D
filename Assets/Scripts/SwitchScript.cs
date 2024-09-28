using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject targetCube;      
    public float targetZPosition = -10.6f;  
    private Vector3 initialPosition;

    void Start()
    {
        if (targetCube != null)
        {
            initialPosition = targetCube.transform.position;
        }
        else
        {
            Debug.LogError("Target cube is not assigned in the inspector.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ball collided with switch");
            
            if (targetCube != null)
            {
                // Update the target cube's Z position
                Vector3 newPosition = new Vector3(initialPosition.x, initialPosition.y, targetZPosition);
                targetCube.transform.position = newPosition;
                
                Debug.Log("Cube moved to new Z position: " + newPosition);
            }
            else
            {
                Debug.LogError("Target cube is not assigned or found.");
            }
        }
        else
        {
            Debug.Log("Collision with non-player object.");
        }
    }
}
