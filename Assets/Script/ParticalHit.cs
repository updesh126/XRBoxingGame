using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalHit : MonoBehaviour
{
    [SerializeField]
    ParticleSystem _particleSystem;
    
    public void PLayHit()
    {
        _particleSystem.Play();
    }
}
