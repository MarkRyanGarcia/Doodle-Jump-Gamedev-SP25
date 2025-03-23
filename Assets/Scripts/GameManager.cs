using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        // Restart game if player falls below the screen
        if (player.position.y < Camera.main.transform.position.y - 6)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}