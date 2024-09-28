using UnityEngine;
using UnityEngine.SceneManagement;  // Import SceneManager

public class LevelUpTrigger : MonoBehaviour
{
    public string targetSceneName = "LevelUp";  // Name of the scene to load

    // This method is called when a trigger occurs
    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the ball (tagged "Player")
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ball entered trigger. Loading LevelUp scene...");
            SceneManager.LoadScene(targetSceneName);
        }
    }
}

