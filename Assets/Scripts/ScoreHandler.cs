using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Transform player; // Assign Player in Inspector
    public TextMeshProUGUI scoreText; // Assign UI Text in Inspector
    private float highestY = 0f; // Track highest point reached

    void Update()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
            scoreText.text = "Score: " + Mathf.FloorToInt(highestY);
        }
    }
}