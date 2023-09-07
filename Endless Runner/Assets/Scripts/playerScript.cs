using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public Rigidbody player;
    public float acceleration;
    public GameObject gameOverPanel;
    public Text lives, highScore;
    int lifeCount = 0;
    public playerScript scriptPlayer;

    private void Start()
    {
        //fetches playerPrefs acceleration
        acceleration = PlayerPrefs.GetFloat("Acceleration", 2000);

        //displays highest score
        highScore.text = "Highest : "+(PlayerPrefs.GetFloat("High Score", 0f)).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        //player controls
        if (Input.GetKey("w")) player.AddForce(0, 0, acceleration * Time.deltaTime);
        if (Input.GetKey("a")) player.AddForce(-acceleration * Time.deltaTime, 0, 0);
        if (Input.GetKey("d")) player.AddForce(acceleration * Time.deltaTime, 0, 0);

        //game over on falling
        if (transform.position.y < 1) Invoke("gameOver",1);

        //life counts
        lives.text = "Lives : "+lifeCount + "/5";      
        if (lifeCount == 5) gameOver();
    }

    public void sensiInput(string sensi)
    {
        Debug.Log("Sensitivity Changed!");
        acceleration = (float.Parse(sensi));
        PlayerPrefs.SetFloat("Acceleration", acceleration);     //playerPrefs acceleration
    }

    //life spent
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") lifeCount++;
    }

    void gameOver()
    {
        Debug.Log("Game Over");
        scriptPlayer.enabled = false;
        gameOverPanel.SetActive(true);

        //playerPrefs High Score
        if (player.position.z - 5 > PlayerPrefs.GetFloat("High Score", 0f)) 
            PlayerPrefs.SetFloat("High Score", player.position.z - 5);
    }
}