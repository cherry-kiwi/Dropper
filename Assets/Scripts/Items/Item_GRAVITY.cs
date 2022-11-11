using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_GRAVITY : MonoBehaviour
{
    Director director;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        director = GameObject.Find("Director").GetComponent<Director>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Physics.gravity = new Vector3(0, Mathf.Abs(Physics.gravity.y), 0); //기본 중력 9.8 ±5
            director.alarm = 2;
            Destroy(gameObject);
        }
    }
}
