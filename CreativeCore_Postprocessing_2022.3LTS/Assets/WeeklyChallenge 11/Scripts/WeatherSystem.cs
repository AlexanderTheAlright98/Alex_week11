using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.VFX;
using TMPro;

public class WeatherSystem : MonoBehaviour
{
    [Header("Global")]
    public Material globalMaterial;
    public Light sunLight;
    public Material defaultSkybox;
    public TMP_Text weatherText;

    [Header("Winter Assets")]
    public VisualEffect snowVFX;
    public Volume winterVolume;
    public Material winterSkybox;

    [Header("Rain Assets")]
    public VisualEffect rainVFX;
    public Volume rainVolume;
    public Material rainSkybox;

    [Header("Autumn Assets")]
    public VisualEffect autumnVFX;
    public Volume autumnVolume;
    public Material autumnSkybox;

    [Header("Summer Assets")]
    public VisualEffect summerVFX;
    public Volume summerVolume;

    private void Start()
    {
        Summer();
    }
    private void DisableAllVolsVFX()
    {
        winterVolume.gameObject.SetActive(false);
        rainVolume.gameObject.SetActive(false);
        autumnVolume.gameObject.SetActive(false);
        summerVolume.gameObject.SetActive(false);
        rainVFX.gameObject.SetActive(false);
        snowVFX.gameObject.SetActive(false);
        autumnVFX.gameObject.SetActive(false);
        summerVFX.gameObject.SetActive(false);
    }
    public void Winter()
    {
        DisableAllVolsVFX();
        globalMaterial.SetFloat("_SnowFade", 1);
        winterVolume.gameObject.SetActive(true);
        snowVFX.gameObject.SetActive(true);
        RenderSettings.skybox = winterSkybox;
    }

    public void Rain()
    {
        DisableAllVolsVFX();
        globalMaterial.SetFloat("_SnowFade", 0);
        rainVolume.gameObject.SetActive(true);
        rainVFX.gameObject.SetActive(true);
        RenderSettings.skybox = rainSkybox;
    }

    public void Autumn()
    {
        DisableAllVolsVFX();
        globalMaterial.SetFloat("_SnowFade", 0);
        autumnVolume.gameObject.SetActive(true);
        autumnVFX.gameObject.SetActive(true);
        RenderSettings.skybox = autumnSkybox;
    }

    public void Summer()
    {
        DisableAllVolsVFX();
        globalMaterial.SetFloat("_SnowFade", 0);
        summerVolume.gameObject.SetActive(true);
        summerVFX.gameObject.SetActive(true);
        RenderSettings.skybox = defaultSkybox;
    }

}
