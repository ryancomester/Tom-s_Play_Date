using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource backgroundMusicPlayer;
    public AudioSource sfxMusicPlayer;
    [Header("Music")]
    public AudioClip gameplayMusic;
    [Header("SFXs")]
    public AudioClip busicutGainedMusic;
    //public AudioClip jumpMusic;

    public static SoundManager soundInstance;

    private void Start()
    {
        backgroundMusicPlayer.clip = gameplayMusic;
        backgroundMusicPlayer.loop = true;
        backgroundMusicPlayer.Play();
    }

    private void Awake()
    {
        if (soundInstance != null && soundInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        soundInstance = this;
        DontDestroyOnLoad(this);
    }

    public void MuteBgAudio()
    {
        backgroundMusicPlayer.mute = !backgroundMusicPlayer.mute;
    }

    public void MuteSFX()
    {
        sfxMusicPlayer.mute = !sfxMusicPlayer.mute;
    }
}
