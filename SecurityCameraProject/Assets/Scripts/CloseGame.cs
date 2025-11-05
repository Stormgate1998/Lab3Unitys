using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game closed."); // visible in editor only

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // stops play mode
#else
        Application.Quit(); // closes the built game
#endif
    }
}