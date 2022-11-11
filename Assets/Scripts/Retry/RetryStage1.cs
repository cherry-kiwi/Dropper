using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryStage1 : MonoBehaviour
{
    public void RetryStage01()
    {
        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1f;
    }
}
