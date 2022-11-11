using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_SpeedUP : MonoBehaviour
{
    public bool isSpeedUpTime = false;
    PlayerCtrl playerCtrl;

    void Start()
    {
        PlayerCtrl playerCtrl = GameObject.Find("speed").GetComponent<PlayerCtrl>(); //Player의 HP 불러옴
        playerCtrl.speed = 10.0f;
    }

    void Update()
    {
        Invoke("speedUp", 5f); //speedUp()을 5초동안 지연           
    }

    void speedUp()
    {
        isSpeedUpTime = true;

        if (isSpeedUpTime)
        {
            playerCtrl.speed += 5.0f;
        }
        else
        {
            playerCtrl.speed -= 5.0f;
        }

        isSpeedUpTime = false;
    }
}
