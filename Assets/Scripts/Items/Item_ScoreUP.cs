using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ScoreUP : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("score").GetComponent<PlayerCtrl>(); //Player�� HP �ҷ���
        playerCtrl.score = 0.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.score += 100.0f;
        }
    }
}
