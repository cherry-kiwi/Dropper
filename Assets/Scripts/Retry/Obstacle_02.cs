using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_02 : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;
    public bool isSpeedDOWNTime = false;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //PlayerÀÇ HP ºÒ·¯¿È
        playerCtrl.HP = 100.0f;
    }

    void speedUp()
    {
        isSpeedDOWNTime = true;

        if (isSpeedDOWNTime)
        {
            playerCtrl.speed -= 5.0f;
        }
        else
        {
            playerCtrl.speed += 5.0f;
        }

        isSpeedDOWNTime = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.HP -= 25;

            Invoke("speedUP", 5f);

            if (playerCtrl.HP <= 0)
            {
                //GameOver
            }
        }
    }
}
