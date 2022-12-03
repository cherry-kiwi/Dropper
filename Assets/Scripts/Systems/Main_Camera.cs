using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Main_Camera : MonoBehaviour
{
    public GameObject player;

    public Volume volume;

    public Vignette vignette;
    public DepthOfField depthOfField;
    public bool Is_On_corutine = false;
    public bool Hit = false;
    public float vignette_speed;

    public ColorAdjustments colorAdjustments;
    public bool Is_On_Invincible = false;
    public bool isInvincible = false;
    public float colorAd_speed;

    void Start()
    {
        volume = GetComponent<Volume>();
        volume.profile.TryGet(out vignette);
        volume.profile.TryGet(out depthOfField);
        volume.profile.TryGet(out colorAdjustments);

        //vignette.active = false;
        //depthOfField.active = false;
        //Is_On_corutine = false;
        //Hit = false;
    }

    void Update()
    {
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position + new Vector3(0, 1, 0);

        if (Hit && Is_On_corutine == false)
        {
            StartCoroutine(Hit_Effect());
        }

        if (isInvincible && Is_On_Invincible == false)
        {
            StartCoroutine(Invincible_Effect());
        }
    }

    IEnumerator Hit_Effect()
    {
        vignette.active = true;
        Is_On_corutine = true;
        Hit = true;
        vignette.intensity.value = 0.5f;
        depthOfField.focalLength.value = 1f;

        for(float i = 0; vignette.intensity.value <= 0.99f; i++)
        {
            vignette.intensity.value += vignette_speed * Time.smoothDeltaTime;
            depthOfField.focalLength.value += 100 * vignette_speed * Time.smoothDeltaTime;
            yield return new WaitForSeconds(0.02f);
        }

        yield return new WaitForSeconds(0.05f);

        for (float i = 0; vignette.intensity.value >= 0.01f; i++)
        {
            vignette.intensity.value -= vignette_speed / 2f * Time.smoothDeltaTime;
            depthOfField.focalLength.value -= 100 * vignette_speed * Time.smoothDeltaTime;
            yield return new WaitForSeconds(0.02f);
        }

        vignette.active = false;
        Is_On_corutine = false;
        Hit = false;
        yield return null;
    }

    IEnumerator Invincible_Effect()
    {
        colorAdjustments.active = true;
        isInvincible = true;
        Is_On_Invincible = true;
        colorAdjustments.hueShift.value = -180.0f;

        for (float i = 1; i * Time.deltaTime * 1 < 6; i++)
        {
            for (float j = 0; colorAdjustments.hueShift.value <= 0; j++)
            {
                colorAdjustments.hueShift.value += 100 * colorAd_speed * Time.smoothDeltaTime;
                yield return new WaitForSeconds(0.02f);
            }

            yield return new WaitForSeconds(0.05f);

            for (float j = 0; colorAdjustments.hueShift.value <= 0; j++)
            {
                colorAdjustments.hueShift.value -= 100 * colorAd_speed * Time.smoothDeltaTime;
                yield return new WaitForSeconds(0.02f);
            }
        }

        colorAdjustments.active = false;
        isInvincible = false;
        Is_On_Invincible = false;

        yield return null;
    }
}