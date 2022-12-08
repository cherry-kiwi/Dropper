using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    public GameObject Button;

    void Start()
    {
        StartCoroutine(BlinkIn());
    }

    public IEnumerator BlinkIn()
    {
        for(float g = 0f; g < 600; g += 0.0001f)
        {
            for (float f = 1f; f > 0.2f; f -= 0.02f)
            {
                Color c = Button.GetComponent<Image>().color;
                c.a = f;
                Button.GetComponent<Image>().color = c;
                yield return null;
            }
            yield return new WaitForSeconds(0.05f);
        
            for (float f = 0.2f; f < 1f; f += 0.02f)
            {
                Color c = Button.GetComponent<Image>().color;
                c.a = f;
                Button.GetComponent<Image>().color = c;
                yield return null;
            }
        }
    }

    //public IEnumerator BlinkOut()
    //{
    //    Button.SetActive(true);
    //    for (float f = 1f; f < 0; f += 0.02f)
    //    {
    //        Color c = Button.GetComponent<Image>().color;
    //        c.a = f;
    //        Button.GetComponent<Image>().color = c;
    //        yield return null;
    //    }
    //}
}