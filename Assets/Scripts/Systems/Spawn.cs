using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public GameObject ST;
    public TMP_Text Text;
    public int num = 3;
    public float timer = 0f;
    public float tick = 1f;
    public bool start = false;

    void Start()
    {
        ST = GameObject.Find("StartTime");
        Text = ST.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if(timer <= 3f && start == false)
        {
            timer += tick * Time.deltaTime;
        }
        else
        {
            start = true;
            gameObject.SetActive(false);
            ST.gameObject.SetActive(false);
        }    

        if(timer >= 0f && num == 3)
        {
            num = 2;
        }
        else if (timer >= 1f && num == 2)
        {
            Text.text = "2";
            num = 1;
        }
        else if (timer >= 2f && num == 1)
        {
            Text.text = "1";
        }
    }
}
