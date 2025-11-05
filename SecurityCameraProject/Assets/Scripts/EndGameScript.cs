using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Robot"))
        {
            Debug.Log("Game Over! Player returned to end zone.");
            ShowGameOver();
            playerController.DisableControl();
            // Add your ending behavior here:
            // SceneManager.LoadScene("MainMenu");
            // or display a UI message, etc.
        }
    }



    public void ShowGameOver()
    {
        gameOverCanvas.SetActive(true);
    }
}
