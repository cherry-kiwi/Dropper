using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_INVINCIBLE : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Invincible()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Invoke("Invincible", 5f); //5초동안 Invincible(무적) 함수 시행
        }
    }
}
