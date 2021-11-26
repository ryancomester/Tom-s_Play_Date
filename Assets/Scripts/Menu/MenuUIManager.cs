using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public GameObject helpMenu;

    [Header("Sprite Images")]
    public Sprite bgSoundOn;
    public Sprite bgSoundOff;
    public Sprite sfxSoundOn;
    public Sprite sfxSoundOff;

    [Header("Buttons")]
    public Button bgAudioBtn;
    public Button sfxAudioBtn;
    private void Start()
    {
        Time.timeScale = 1;

        helpMenu.SetActive(false);

    }

    private void Update()
    {
        if (SoundManager.soundInstance.backgroundMusicPlayer.mute)
            bgAudioBtn.image.sprite = bgSoundOff;
        else
            bgAudioBtn.image.sprite = bgSoundOn;

        if (SoundManager.soundInstance.sfxMusicPlayer.mute)
            sfxAudioBtn.image.sprite = sfxSoundOff;
        else
            sfxAudioBtn.image.sprite = sfxSoundOn;


    }

    //takes user to the level1 where the game is.
    public void PlayGameBtn()
    {
        SceneManager.LoadScene("Level1");
    }

    public void helpMenuBtn()
    {
        helpMenu.SetActive(true);
    }

    public void helpExitBtn()
    {
        helpMenu.SetActive(false);
    }

    public void BgAudioMuteBtn()
    {
        SoundManager.soundInstance.MuteBgAudio();
    }
    public void SfxMuteBtn()
    {
        SoundManager.soundInstance.MuteSFX();
    }
}
