using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_01 : MonoBehaviour
{
    PlayerCtrl playerCtrl;
    public Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        PlayerCtrl playerCtrl = GameObject.Find("HP").GetComponent<PlayerCtrl>(); //Player�� HP �ҷ���
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerCtrl.HP -= 50;

            if (playerCtrl.HP <= 0)
            {
                GameObject.Find("GameOverCanvas").transform.Find("GameOverPanel").gameObject.SetActive(true);
                Time.timeScale = 0; //시간 흐름 멈춘 상태
            }
        }
    }
}
