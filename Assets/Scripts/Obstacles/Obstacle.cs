using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        playerCtrl = GameObject.Find("Player").GetComponent<PlayerCtrl>(); //PlayerÀÇ HP ºÒ·¯¿È
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.HP -= 50.0f;
            Destroy(gameObject);
        }
    }
}
