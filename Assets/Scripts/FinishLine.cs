using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has crossed the finish line
        if (true)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        // Implement the logic to end the game
        Debug.Log("Game Over! You crossed the finish line.");

        // UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");

        // Example: Quit the application
        // Application.Quit();
    }
}
