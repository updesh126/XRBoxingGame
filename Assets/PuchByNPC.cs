using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchByNPC : MonoBehaviour
{

    [SerializeField]
    AudioSource HitAudio;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hhiiiiiiii");
        if(other.gameObject.tag == "Left" ||  other.gameObject.tag == "Right")
        {
            Debug.Log("hit by npc");
            HitAudio.Play();
        }
    }
}
