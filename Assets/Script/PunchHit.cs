using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PunchHit : MonoBehaviour
{
    [SerializeField]
    private ScoreSystem scoreSystem;

    [SerializeField]
    AudioSource Audio;

    /// <summary>
    /// [SerializeField] private GameObject SpawnerSystem;
    /// </summary>

    //[SerializeField] bool H_Left=false, H_Right=false;

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if (other.gameObject.tag == "red")
        {
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Audio.Play();
        }
        if (other.gameObject.tag == "blue")
        {
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Audio.Play();
        }
    }

}
