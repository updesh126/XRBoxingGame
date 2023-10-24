using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchByNPC : MonoBehaviour
{

    [SerializeField]
    AudioSource HitAudio;

    scoreSyem0 scoreSyem = new scoreSyem0();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hhiiiiiiii");
        if(other.gameObject.tag == "NPC")
        {
            Debug.Log("hit by npc");
            HitAudio.Play();
            scoreSyem.RedScoreAdd();
        }
    }
}
