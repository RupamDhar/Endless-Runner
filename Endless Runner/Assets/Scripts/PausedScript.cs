using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

//pausedScript for in-game canvas
public class PausedScript : MonoBehaviour
{
    public GameObject pausePanel, settingPanel;
    bool isPaused = false;
    public Text score, lives, acceleration;
    public Transform player;
    public AudioSource playerAudio;
    public Slider valueAdjust;

    private void Start()
    {
        //sets initial slider position
        valueAdjust.value = playerAudio.volume;

        //sets placeholder text in sensi input
        acceleration.text = PlayerPrefs.GetFloat("Acceleration", 2000).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            if (isPaused == false) pause();
            else if (isPaused == true) resume();
        }
        score.text = (player.position.z - 5).ToString("0");
    }

    public void setting()
    {
        Debug.Log("Setting");
        settingPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void pause()
    {
        Debug.Log("Pause");
        Time.timeScale = 0f;
        score.enabled = false;
        lives.enabled = false;
        pausePanel.SetActive(true);
        isPaused = true;
    }
    
    public void resume()
    {
        Debug.Log("Resumed");
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        settingPanel.SetActive(false);
        score.enabled = true;
        lives.enabled = true;
        isPaused = false;
    }

    public void restart()
    {
        Debug.Log("Restarted");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(2);
    }
}
