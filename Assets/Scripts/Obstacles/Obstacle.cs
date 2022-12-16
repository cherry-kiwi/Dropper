using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public Main_Camera Cam;
    PlayerCtrl playerCtrl;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        Cam = GameObject.Find("CenterEyeAnchor").GetComponent<Main_Camera>();
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerCtrl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Cam.Hit = true;
            playerCtrl.HP -= 10.0f;
            Destroy(gameObject);
        }
    }
}