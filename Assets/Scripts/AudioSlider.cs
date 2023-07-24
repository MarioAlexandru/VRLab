using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class AudioSlider : MonoBehaviour
{

    [SerializeField]
    private AudioMixer Mixer;
    [SerializeField]
    private AudioSource AudioSource;
    [SerializeField]
    private TextMeshProUGUI ValueText;
    private AudioMixMode MixMode;

    public void OnChangeSlider(float Value)
    {
        ValueText.SetText($"{Value.ToString("N4")}");

        switch (MixMode)
        {
            case AudioMixMode.LinearAudioSourceVolume:
                AudioSource.volume = Value;
                break;
            case AudioMixMode.LinearMixerVolume:
                Mixer.SetFloat("Volume", (-80 + Value * 100));
                break;
            case AudioMixMode.LogarithmicMixerVolume:
                Mixer.SetFloat("Volume", Mathf.Log10(Value) * 20);
                break;
                
        }
        PlayerPrefs.SetFloat("Volume", Value);
        PlayerPrefs.Save();
    }

    public enum AudioMixMode
    {
        LinearAudioSourceVolume,
        LinearMixerVolume,
        LogarithmicMixerVolume
    }
    private void Start()
    {
        Mixer.SetFloat("Volume", Mathf.Log10(PlayerPrefs.GetFloat("Volume",1)*20));
    }
}
