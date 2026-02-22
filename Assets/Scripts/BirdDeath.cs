using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class BirdDeath : MonoBehaviour
{
    public GameObject gameOverPanel; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
    // 1. Reset time so the next scene isn't frozen
    Time.timeScale = 1f;

    // 2. Load the "Start" scene. 
    // Use index 0 if it's the first scene in your build settings.
    SceneManager.LoadScene(1); 
}
}