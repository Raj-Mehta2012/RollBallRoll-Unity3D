using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallFallDetection : MonoBehaviour
{
    public float fallThreshold = -10f;     
    public float delayBeforeGameOver = 3f; 

    void Update()
    {

        if (transform.position.y < fallThreshold)
        {
            StartCoroutine(LoadGameOverScene());
        }
    }


    IEnumerator LoadGameOverScene()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeGameOver);

        // Load the GameOver scene
        SceneManager.LoadScene("GameOver");
    }
}
