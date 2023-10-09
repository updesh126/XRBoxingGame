using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject[] cubes;
    public Transform[] Lpoints;
    public Transform[] Rpoints;
    public float beat= (60/130)*2;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            GameObject Lcube = Instantiate(cubes[0], Lpoints[Random.Range(0, 4)]);
            GameObject Rcube = Instantiate(cubes[1], Rpoints[Random.Range(0, 4)]);
            Lcube.transform.localPosition = Vector3.zero;
            Rcube.transform.localPosition = Vector3.zero;
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}
