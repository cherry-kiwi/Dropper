using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class ctrl : MonoBehaviour
{
    //Combine���
    void Update()
    {
        //PrimaryIndexTrigger �޼� Ʈ���� ��ư
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("�޼� Ʈ���� ��ư Ŭ��");
        }
        //SecondaryIndexTrigger ������ Ʈ���� ��ư
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("������ Ʈ���� ��ư Ŭ��");
        }
    }
}