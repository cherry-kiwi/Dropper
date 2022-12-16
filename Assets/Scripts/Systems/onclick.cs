using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVR;

public class onclick : MonoBehaviour
{
    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (scene.name == "Stage0")
            {
                start_button();
            }
            else if (scene.name == "Stage0_5")
            {
                infi();
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (scene.name == "Stage0")
            {
                start_button();
            }
            else if (scene.name == "Stage0_5")
            {
                stage();
            }
        }
    }

    public void start_button()
    {
        SceneManager.LoadScene("Stage0_5");
    }

    public void infi()
    {
        SceneManager.LoadScene("infinite");
    }

    public void stage()
    {
        SceneManager.LoadScene("Stage1");
    }
}
