using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgame : MonoBehaviour
{
    [SerializeField]
    Animator Bot;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YES");
        if (other.gameObject.tag == "Start")
        {
            Debug.Log("heelo");
            Bot.enabled = true;
        }
    }
}
