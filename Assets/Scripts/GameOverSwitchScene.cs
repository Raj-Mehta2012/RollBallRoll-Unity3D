using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneManager : MonoBehaviour
{
    // Method to load the GameScene
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
