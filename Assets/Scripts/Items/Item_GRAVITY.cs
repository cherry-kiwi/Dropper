using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_GRAVITY : MonoBehaviour
{
    Physics physics;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Physics.gravity = new Vector3(0, Mathf.Clamp(Time.time, 4.8f, 18.8f), 0); //�⺻ �߷� 9.8 ��5
        }
    }
}