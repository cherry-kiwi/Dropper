using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_HPUP_02 : MonoBehaviour
{
    PlayerCtrl playerCtrl;

    void Start()
    {
        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //Player�� HP �ҷ���
        playerCtrl.HP = 100.0f;
    }

    void Update()
    {
        if (playerCtrl.HP < 100) //HP�� 100�̸��϶�
        {
            playerCtrl.HP += 50; //HP�� 50 ���ϱ�

            if (playerCtrl.HP >= 100) //HP�� 100�̻� �ɶ�
            {
                playerCtrl.HP = 100; //100���� �����ֱ�
            }
        }
    }
}
