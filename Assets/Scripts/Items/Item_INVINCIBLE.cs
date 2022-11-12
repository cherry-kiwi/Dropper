using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_INVINCIBLE : MonoBehaviour
{
    bool isInvincible = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Invincible()
    {
        isInvincible = true;
        if (isInvincible)
        {

        }
        isInvincible = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Invoke("Invincible", 5f); //5초동안 Invincible(무적) 함수 시행
        }
    }
}
