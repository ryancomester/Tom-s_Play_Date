using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Text muteBtnText;

    public static SoundManager soundInstance;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

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

    private void Update()
    {
        if (audioSource.mute)
            muteBtnText.text = "Unmute Audio";
        else
            muteBtnText.text = "Mute Audio";
    }

    public void MuteBGSound()
    {
        audioSource.mute = !audioSource.mute;
    }
 }
