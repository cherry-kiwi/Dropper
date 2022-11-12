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

    //private float invincibleTime; //���� ������ �ð��� �󸶳� �귶�°� �Ǵ��ϱ� ���� ����
    //bool isInvincible; //���� �����ΰ� �Ǵ�
    //public GameObject PostProcessingCamera;

    //void Start()
    //{
    //    Cam = GameObject.Find("Main Camera").GetComponent<Main_Camera>();

    //    isInvincible = false; //���� ���� ����
    //    PostProcessingCamera.gameObject.SetActive(false); //����Ʈ ���μ��� �����ϴ� ī�޶� ��Ȱ��ȭ
    //}

    //void Update()
    //{

    //}

    //void Invincible()
    //{
    //    if (isInvincible) //���� ������ ��
    //    {
    //        PostProcessingCamera.gameObject.SetActive(true); //����Ʈ ���μ��� �����ϴ� ī�޶� Ȱ��ȭ
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        if(invincibleTime > 0) //���� �ð��� �帣�� �ʾ��� ��
    //        {
    //            isInvincible = true; //���� ���� ����

    //            Invincible();
    //            invincibleTime += 1 * Time.deltaTime; //���� �ð� 1�ʾ� �帣��
    //        }

    //        else if (invincibleTime <= 3)
    //        {

    //        }
    //    }
    //}
}