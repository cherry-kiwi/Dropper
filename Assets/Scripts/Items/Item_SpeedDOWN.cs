using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_SpeedDOWN : MonoBehaviour
{
    public bool isSpeedDOWNTime = false;
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("speed").GetComponent<PlayerCtrl>(); //Player의 HP 불러옴
        playerCtrl.speed = 10.0f;
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
            Invoke("speedUp", 5f); //speedUp()을 5초동안 지연           
        }
    }
}
