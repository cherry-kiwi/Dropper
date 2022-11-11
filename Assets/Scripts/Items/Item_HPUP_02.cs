using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_HPUP_02 : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //Player의 HP 불러옴
        playerCtrl.HP = 100.0f;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (playerCtrl.HP < 100) //HP가 100미만일때
            {
                playerCtrl.HP += 50; //HP에 50 힐하기

                if (playerCtrl.HP >= 100) //HP가 100이상 될때
                {
                    playerCtrl.HP = 100; //100으로 맞춰주기
                }
            }
        }
    }
}
