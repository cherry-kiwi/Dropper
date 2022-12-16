using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_2Wall_3 : MonoBehaviour
{
    int a = 1;

    void Update()
    {
        if (transform.position.z <= 2.5f)
        {
            a = 1;
        }
        else if (transform.position.z > 4.5f)
        {
            a = -1;
        }

        transform.Translate(Vector3.up * 1.0f * Time.deltaTime * a);
    }
}