using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHit : MonoBehaviour
{

    [SerializeField]
    AudioSource HitAudio;

    scoreSyem0 scoreSyem = new scoreSyem0();


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hhiiiiiiii");
        if (other.gameObject.tag == "Right" || other.gameObject.tag == "Left")
        {
            Debug.Log("hit by Player");
            HitAudio.Play();
            scoreSyem.BlueScoreAdd();
        }
    }
}
