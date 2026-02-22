using UnityEngine;
using UnityEngine.SceneManagement; // This is the important part!

public class SceneChanger : MonoBehaviour
{
    public void LoadGame()
    {
        // Replace "SampleScene" with the exact name of your next scene
        SceneManager.LoadScene("Game");
    }
}