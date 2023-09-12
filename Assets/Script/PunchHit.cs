using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchHit : MonoBehaviour
{
    [SerializeField]
    private ScoreSystem scoreSystem;

    [SerializeField] private GameObject SpawnerSystem;

    [SerializeField] bool H_Left, H_Right;
    private void OnTriggerEnter(Collider other)
    {
        if(H_Left == true && H_Right == false && other.gameObject.tag == "red")
        {
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Debug.Log("Hit by left hand");
        }
        if (H_Left == false && H_Right == true && other.gameObject.tag == "blue")
        {
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Debug.Log("Hit by Right hand");
        }
        else
        {
            scoreSystem.RemoveScore();

            SpawnerSystem.SetActive(false);
            Debug.Log("Wrong Hit");

            //other.gameObject.SetActive(false);
        }
    }
}
