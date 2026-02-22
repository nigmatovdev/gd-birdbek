using UnityEngine;
using UnityEngine.SceneManagement; // This line allows scene switching

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // This loads the scene at Index 1 (SampleScene)
        SceneManager.LoadScene(0); 
    }
}