using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    
    public Text scoreText;       // Main gameplay score
    public Text finalScoreText;  // Text on your Game Over panel
    private int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Initialize texts
        scoreText.text = "0";
        if(finalScoreText != null) finalScoreText.text = "Score: 0";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * speed; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreZone"))
        {
            score++;
            // Update both UI elements
            scoreText.text = score.ToString();
            
            if(finalScoreText != null) 
            {
                finalScoreText.text = "Score: " + score.ToString();
            }

            Debug.Log("Score is now: " + score);
        }
    }
}