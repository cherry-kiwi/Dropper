using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_01 : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //PlayerÀÇ HP ºÒ·¯¿È
        playerCtrl.HP = 100.0f;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.HP -= 50;

            if (playerCtrl.HP <= 0)
            {
                //GameOver
            }
        }
    }
}
