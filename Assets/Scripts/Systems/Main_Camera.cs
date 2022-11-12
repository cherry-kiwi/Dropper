using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Main_Camera : MonoBehaviour
{
    public GameObject player;
    public float vignette_speed;

    public Volume volume;
    public Vignette vignette;
    public DepthOfField depthOfField;
    public bool Is_On_corutine = false;
    public bool Hit = false;

    void Start()
    {
        volume = GetComponent<Volume>();
        volume.profile.TryGet(out vignette);
        volume.profile.TryGet(out depthOfField);

        //vignette.active = false;
        //depthOfField.active = false;
        //Is_On_corutine = false;
        //Hit = false;
    }
    void Update()
    {
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position;

        if (Hit && Is_On_corutine == false)
        {
            StartCoroutine(Hit_Effect());
        }
    }
    IEnumerator Hit_Effect()
    {
        vignette.active = true;
        Is_On_corutine = true;
        Hit = true;
        depthOfField.active = true;
        vignette.intensity.value = 0f;
        depthOfField.focalLength.value = 0;

        for(float i = 0; vignette.intensity.value <= 0.5f; i++)
        {
            vignette.intensity.value += vignette_speed * Time.smoothDeltaTime;
            depthOfField.focalLength.value += 100 * vignette_speed * Time.smoothDeltaTime;
            yield return new WaitForSeconds(0.02f);
        }

        yield return new WaitForSeconds(0.05f);

        for (float i = 0; vignette.intensity.value <= 0.5f; i++)
        {
            vignette.intensity.value -= vignette_speed * Time.smoothDeltaTime;
            depthOfField.focalLength.value -= 100 * vignette_speed * Time.smoothDeltaTime;
            yield return new WaitForSeconds(0.02f);
        }

        vignette.active = false;
        depthOfField.active = false;
        Is_On_corutine = false;
        Hit = false;
        yield return null;
    }
}