//NOT WORKING(the position of instantiation)

using UnityEngine;

public class instantiationScript : MonoBehaviour
{
    public GameObject[] obstacleGrp;
    public Rigidbody player;
    //private bool isSpawned = false; //for spawning obstacle one time when player reach factor 70 position
    private Vector3 newObstaclePos = new Vector3(0, 0, 186);

    // Update is called once per frame
    void Update()
    { 
        //if (ObsOffsetFromPrev.z -player.position.z > 35) spawn();

        int playerPos = (int) player.position.z;
        //if (playerPos % 70 != 0) isSpawned = false;
        if (playerPos % 70==0) spawn();
    }

    void spawn()
    {
        int random = Random.Range(0, 1);
        Debug.Log("Obstacle Spawned"+random);
        Instantiate(obstacleGrp[random], newObstaclePos, transform.rotation);
        //isSpawned = true;
        newObstaclePos.z += 100; 
    }
}
