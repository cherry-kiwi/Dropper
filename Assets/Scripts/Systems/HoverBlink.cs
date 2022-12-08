using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverBlink : MonoBehaviour
{
    public GameObject StageMode;
    public GameObject InfinityMode;

    void OnMouseOver()
    {
        StartCoroutine(StageModeBlink());
        StartCoroutine(InfinityModeBlink());
    }

    public IEnumerator StageModeBlink()
    {
        for (float g = 0f; g < 600; g += 0.0001f)
        {
            for (float f = 1f; f > 0.2f; f -= 0.02f)
            {
                Color c = StageMode.GetComponent<Image>().color;
                c.a = f;
                StageMode.GetComponent<Image>().color = c;
                yield return null;
            }
            yield return new WaitForSeconds(0.05f);

            for (float f = 0.2f; f < 1f; f += 0.02f)
            {
                Color c = StageMode.GetComponent<Image>().color;
                c.a = f;
                StageMode.GetComponent<Image>().color = c;
                yield return null;
            }
        }
    }

    public IEnumerator InfinityModeBlink()
    {
        for (float g = 0f; g < 600; g += 0.0001f)
        {
            for (float f = 1f; f > 0.2f; f -= 0.02f)
            {
                Color c = InfinityMode.GetComponent<Image>().color;
                c.a = f;
                InfinityMode.GetComponent<Image>().color = c;
                yield return null;
            }
            yield return new WaitForSeconds(0.05f);

            for (float f = 0.2f; f < 1f; f += 0.02f)
            {
                Color c = InfinityMode.GetComponent<Image>().color;
                c.a = f;
                InfinityMode.GetComponent<Image>().color = c;
                yield return null;
            }
        }
    }
}
