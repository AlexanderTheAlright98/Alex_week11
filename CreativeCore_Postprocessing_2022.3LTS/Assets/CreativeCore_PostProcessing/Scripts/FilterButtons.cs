using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class FilterButtons : MonoBehaviour
{
    public Volume globalVolume;
    ColorAdjustments greyScale;
    ChromaticAberration chromab;

    bool isGreyScale = false;
    bool isChromab = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        globalVolume.profile.TryGet(out greyScale);
        globalVolume.profile.TryGet(out chromab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!isGreyScale)
            {
                greyScale.saturation.value = -100;
                isGreyScale = true;
                Debug.Log("turn greyscale");
            }
            else
            {
                greyScale.saturation.value = 32.8f;
                Debug.Log("back to normal");
                isGreyScale = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!isChromab)
            {
                chromab.intensity.value = 1;
                isChromab = true;
            }
            else
            {
                chromab.intensity.value = 0.037f;
                isChromab = false;
            }
        }
    }
}
