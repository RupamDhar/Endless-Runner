using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour
{
    public GameObject gameobject;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        Destroy(gameObject);
    }
}
