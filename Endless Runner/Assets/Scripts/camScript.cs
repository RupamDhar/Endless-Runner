using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public int volumeFactor=5;
    bool tpp = true;

    // Update is called once per frame
    void Update()
    {
        if (tpp == true) transform.position = player.position + offset;
        else transform.position = player.position;
    }

    //cam position tpp/fpp
    public void tppToggle(bool tpptoggle)
    {
        tpp = tpptoggle;
    }
    //music volume adjust
    public void audioChange(float volume)
    {
        AudioListener.volume = volume*volumeFactor;
    }
}
