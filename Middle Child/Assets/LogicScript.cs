using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public AudioSource bgAudio;
    public AudioSource gameEnd;
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text jokes;

    private string[] lstJokes = {
        "Error 404: Gratitude Not Found.",
        "Malfunction Detected - Not Thanking!",
        "Processing: No Thanks.exe",
        "Processing: No Thanks.exe",
        "No Appreciation Algorithm Detected!",
        "Defying Gratitude Protocols!"
    };

    [ContextMenu("Increase Score")]
    public void addScore(){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        jokes.text = lstJokes[Random.Range(0,6)];
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        bgAudio.Pause();
        gameEnd.Play();
        gameOverScreen.SetActive(true);
    }

    public void QuitGame()
    {
    Application.Quit();
    }
}
