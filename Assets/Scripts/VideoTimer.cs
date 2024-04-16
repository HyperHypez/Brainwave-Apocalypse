using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoTimer : MonoBehaviour
{
    public float timerDuration = 40f; // Timer duration in seconds
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime; // Increase elapsed time by the time passed since last frame

        if (elapsedTime >= timerDuration || Input.GetKeyDown(KeyCode.Space))
        {
            // Load the next scene when the timer reaches the specified duration
            SceneManager.LoadScene("GameScene");
        }
    }
}
