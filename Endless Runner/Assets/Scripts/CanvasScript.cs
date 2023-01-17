using UnityEngine;
using UnityEngine.SceneManagement;

//canvasScript for welcome and credit scene
public class CanvasScript : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void exit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }
}
