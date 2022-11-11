using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryStage3 : MonoBehaviour
{
    public void RetryStage03()
    {
        SceneManager.LoadScene("Stage3");
        Time.timeScale = 1f;
    }
}
