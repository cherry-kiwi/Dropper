using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    public float alarm = 0;
    public bool isAlarm = false;

    void Update()
    {
        if (alarm > 0)
        {
            alarm -= 1 * Time.deltaTime;
        }
        else
        {
            isAlarm = true;
        }

        if(isAlarm)
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            isAlarm = false;
        }
    }
}
