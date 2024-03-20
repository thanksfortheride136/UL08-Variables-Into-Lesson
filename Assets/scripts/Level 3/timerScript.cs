using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class timerScript : MonoBehaviour
{
    public float time = 15;
    public TextMeshProUGUI UITimer;
    private bool gameEnded = false; // Added boolean to track if the game has ended

    // Start is called before the first frame update
    void Start()
    {
        // Your start initialization
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded) return; // Check if game has already ended

        time -= Time.deltaTime; // Optimized time decrement
        UITimer.text = "Timer:" + " " + Mathf.Floor(time);

        if (time <= 0 && destroyBags.bagsCollected < 10)
        {
            // Switch to game over screen
            SceneManager.LoadScene("gameOverScreen", LoadSceneMode.Additive);
            Destroy(GameObject.Find("level"));
            Destroy(GameObject.Find("timerText"));
            Destroy(GameObject.Find("instructionsText"));
            gameEnded = true; // Set the flag to true as the game has ended
        }
        else if (destroyBags.bagsCollected >= 10 && time <= 0)
        {
            // Show win screen
            SceneManager.LoadScene("winScreen", LoadSceneMode.Additive);
            Destroy(GameObject.Find("level"));
            Destroy(GameObject.Find("timerText"));
            Destroy(GameObject.Find("instructionsText"));
            gameEnded = true; // Set the flag to true as the game has ended
        }
    }
}
