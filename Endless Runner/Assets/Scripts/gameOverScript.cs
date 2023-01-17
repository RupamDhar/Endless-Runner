using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameOverScript : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(2);
    }
}
