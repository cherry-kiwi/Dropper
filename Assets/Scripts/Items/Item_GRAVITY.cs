using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_GRAVITY : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    Physics physics;
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("gravity").GetComponent<PlayerCtrl>(); //Player의 HP 불러옴
        playerCtrl.gravity = 9.8f;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Physics.gravity = new Vector3(0, Mathf.Clamp(Time.time, 4.8f, 18.8f), 0); //기본 중력 9.8 ±5
        }
    }
}
