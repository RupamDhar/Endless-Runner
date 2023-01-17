using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour
{
    public int lifeCount = 0;
    public GameObject gameOverPanel;
    //public Text lives;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") lifeCount++;
    }

    // Update is called once per frame
    void Update()
    {
        //lives.text = lifeCount + "/5";

        if(lifeCount == 5)
        {
            Debug.Log("Game Over");
            gameOverPanel.SetActive(true);
        }
    }
}
