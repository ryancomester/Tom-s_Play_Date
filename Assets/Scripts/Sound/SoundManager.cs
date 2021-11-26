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
    public AudioClip gameOverMusic;

    [Header("SFXs")]
    public AudioClip busicutGainedMusic;
    public AudioClip jumpMusic;
    public AudioClip swipeAudio;

    public static SoundManager soundInstance;

    private void Start()
    {
        backgroundMusicPlayer.clip = gameplayMusic;
        backgroundMusicPlayer.loop = true;
        backgroundMusicPlayer.Play();

        /*gets the last saved preferences and loads it.*/
        if (EndScoreSys.LoadBgAudioPreference())
            backgroundMusicPlayer.mute = true;
        else
            backgroundMusicPlayer.mute = false;

        if (EndScoreSys.LoadSFXPreference())
            sfxMusicPlayer.mute = true;
        else
            sfxMusicPlayer.mute = false;
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
 
        /*takes the current status and saves it*/
        EndScoreSys.SaveBgAudioPreference(backgroundMusicPlayer.mute);
    }

    public void MuteSFX()
    {
        sfxMusicPlayer.mute = !sfxMusicPlayer.mute;

        /*takes the current status of the SFX and sends it to save*/
        EndScoreSys.SaveSFXPreference(sfxMusicPlayer.mute);
    }

    public void GameOverMusic()
    {
        backgroundMusicPlayer.Stop();
        backgroundMusicPlayer.clip = gameOverMusic;
        backgroundMusicPlayer.Play();
    }
}
