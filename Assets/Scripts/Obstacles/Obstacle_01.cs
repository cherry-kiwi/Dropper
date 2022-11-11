using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_01: MonoBehaviour
{
    PlayerCtrl playerCtrl;
    //PlayerCtrl playerCtrl2;
    public Rigidbody rigid;
    public bool isSpeedDOWNTime = false;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //Player�� HP �ҷ���
        //PlayerCtrl playerCtrl2 = GameObject.Find("Speed").GetComponent<PlayerCtrl>(); //Player�� Speed �ҷ���

        playerCtrl.HP = 100.0f;
        //playerCtrl2.speed = 10.0f;
    }

    void Update()
    {

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
            playerCtrl.HP -= 50;
            //playerCtrl2.speed -= 10;

            Invoke("speedUP", 5f);

            if (playerCtrl.HP <= 0)
            {
                //GameOver
            }
        }
    }
}
