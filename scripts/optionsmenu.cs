using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class optionsmenu : MonoBehaviour
{
    public AudioMixer Audio;

   
    public void SetVolume(float volume)
    {
        Audio.SetFloat("Volume", volume);
    }

    public void SetGraphicsQuality (int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);
    }

    public void FullScreenSelected(bool isfull)
    {
        Screen.fullScreen = isfull;
    }
}
