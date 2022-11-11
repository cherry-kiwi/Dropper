using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    Main_Camera Cam;
    PlayerCtrl playerCtrl;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        Cam = GameObject.Find("Main Camera").GetComponent<Main_Camera>();
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerCtrl>(); //Player�� HP �ҷ���
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Cam.Hit = true;
            playerCtrl.HP -= 50.0f;
            Destroy(gameObject);
        }
    }
}
