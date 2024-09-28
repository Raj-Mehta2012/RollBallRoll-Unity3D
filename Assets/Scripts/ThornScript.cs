using UnityEngine;
using UnityEngine.SceneManagement;  // Import SceneManager

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Thorns"))
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }
}

