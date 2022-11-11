using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryStage2 : MonoBehaviour
{
    public void RetryStage02()
    {
        SceneManager.LoadScene("Stage2");
        Time.timeScale = 1f;
    }
}
