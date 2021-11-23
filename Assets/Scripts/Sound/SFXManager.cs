using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXManager : MonoBehaviour
{
    public Text sfxMuteBtn;
    public AudioSource Audio;
    public AudioClip coinAcquired;

    public static SFXManager SFXInstance;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();

    }

    private void Awake()
    {
        if (SFXInstance != null && SFXInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        SFXInstance = this;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (Audio.mute)
            sfxMuteBtn.text = "Unmute SFX";
        else
            sfxMuteBtn.text = "Mute Audio";
    }

    public void MuteSFXSound()
    {
        Audio.mute = !Audio.mute;
    }
}
