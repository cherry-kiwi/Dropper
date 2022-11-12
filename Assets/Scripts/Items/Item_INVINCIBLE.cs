using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_INVINCIBLE : MonoBehaviour
{
    Main_Camera Cam;
    Director director;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        director = GameObject.Find("Director").GetComponent<Director>();
        Cam = GameObject.Find("Main Camera").GetComponent<Main_Camera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Cam.isInvincible = true;
            Destroy(gameObject);
        }
    }

    //private float invincibleTime; //무적 상태의 시간이 얼마나 흘렀는가 판단하기 위한 변수
    //bool isInvincible; //무적 상태인가 판단
    //public GameObject PostProcessingCamera;

    //void Start()
    //{
    //    Cam = GameObject.Find("Main Camera").GetComponent<Main_Camera>();

    //    isInvincible = false; //무적 상태 해제
    //    PostProcessingCamera.gameObject.SetActive(false); //포스트 프로세싱 관리하는 카메라 비활성화
    //}

    //void Update()
    //{

    //}

    //void Invincible()
    //{
    //    if (isInvincible) //무적 상태일 때
    //    {
    //        PostProcessingCamera.gameObject.SetActive(true); //포스트 프로세싱 관리하는 카메라 활성화
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        if(invincibleTime > 0) //무적 시간이 흐르지 않았을 때
    //        {
    //            isInvincible = true; //무적 상태 설정

    //            Invincible();
    //            invincibleTime += 1 * Time.deltaTime; //무적 시간 1초씩 흐르게
    //        }

    //        else if (invincibleTime <= 3)
    //        {

    //        }
    //    }
    //}
}