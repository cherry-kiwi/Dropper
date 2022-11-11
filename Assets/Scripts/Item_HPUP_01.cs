using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_HPUP_01 : MonoBehaviour
{
    PlayerCtrl playerCtrl;

    void Start()
    {
        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //Player의 HP 불러옴
        playerCtrl.HP = 100.0f;
    }

    void Update()
    {
        if (playerCtrl.HP < 100) //HP가 100미만일때
        {
            playerCtrl.HP += 20; //HP에 20 힐하기

            if (playerCtrl.HP >= 100) //HP가 100이상 될때
            {
                playerCtrl.HP = 100; //100으로 맞춰주기
            }
        }
    }
}
