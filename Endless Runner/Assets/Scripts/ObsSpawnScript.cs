﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawnScript : MonoBehaviour
{
    public GameObject obstacleGrp;
    public bool isSpawned = false;
    public Transform playerPos; public Rigidbody player;
    public float playerObsGrpDiff;
    public Vector3 ObsOffsetFromPrev;
    public int timeBeforeDestruct=5;
    public int maxGrpCapacity=5;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z - playerPos.position.z < playerObsGrpDiff && isSpawned==false)
        {
            //Debug.Log(transform.position.z - player.position.z);
            Spawn();
        }
    }

    public void Spawn()
    {
        Debug.Log("Spawned grp ");
        Instantiate(obstacleGrp, transform.position+ ObsOffsetFromPrev, transform.rotation);
        isSpawned = true;
        if(player.position.z > transform.position.z) Destroy(obstacleGrp, timeBeforeDestruct);
    }
}
