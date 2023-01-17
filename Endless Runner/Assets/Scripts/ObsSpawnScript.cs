using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawnScript : MonoBehaviour
{
    public GameObject obstacleGrp;
    public bool isSpawned = false;
    public Transform player;
    public float playerObsGrpDiff;
    public Vector3 ObsOffsetFromPrev;
    public int timeBeforeDestruct=1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z - player.position.z < playerObsGrpDiff && isSpawned==false)
        {
            //Debug.Log(transform.position.z - player.position.z);
            Spawn();
        }
    }

    public void Spawn()
    {
        
        Debug.Log("Spawned");
        Instantiate(obstacleGrp, transform.position+ ObsOffsetFromPrev, transform.rotation);
        isSpawned = true;
        Destroy(obstacleGrp,timeBeforeDestruct);
    }
}
