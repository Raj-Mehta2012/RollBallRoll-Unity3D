using UnityEngine;
using UnityEngine.SceneManagement;  // Import the SceneManager

public class SceneSwitcher : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("GameScene");  
    }

    public void ControlsScene()
    {
        SceneManager.LoadScene("ControlsScene");  
    }

    public void SplashScene()
    {
        SceneManager.LoadScene("SplashScreen");  
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");  
        Application.Quit();  // Quits the application in a built version
    }
}
