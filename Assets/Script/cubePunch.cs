using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePunch : MonoBehaviour
{
    [SerializeField]
    private ScoreSystem scoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 2;
    }
    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if(other.gameObject.tag == "Left")
        {
            gameObject.SetActive(false);
            scoreSystem.AddScore();
        } 
        if(other.gameObject.tag == "Right")
        {
            gameObject.SetActive(false);
            scoreSystem.AddScore();
        }
    }*/
}
