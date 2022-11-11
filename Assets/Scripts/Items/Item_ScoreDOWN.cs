using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ScoreDOWN : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("score").GetComponent<PlayerCtrl>(); //PlayerÀÇ HP ºÒ·¯¿È
        playerCtrl.score = 0.0f;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.score -= 100.0f;
        }
    }
}
