using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class ctrl : MonoBehaviour
{
    //Combine방식
    void Update()
    {
        //PrimaryIndexTrigger 왼손 트리거 버튼
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("왼손 트리거 버튼 클릭");
        }
        //SecondaryIndexTrigger 오른손 트리거 버튼
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("오른손 트리거 버튼 클릭");
        }
    }
}