using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public ParticleSystem particle;

    private void Start()
    {
        particle.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            goal.gameObject.SetActive(true);
            particle.Play();
        }
    }
}
