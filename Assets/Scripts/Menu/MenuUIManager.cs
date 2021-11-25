using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public GameObject helpMenu;
    public Text backgroundAudioMuteBtn;
    public Text sfxAudoBtn;

    private void Start()
    {
        Time.timeScale = 1;

        helpMenu.SetActive(false);
    }

    private void Update()
    {
        if (SoundManager.soundInstance.backgroundMusicPlayer.mute)
            backgroundAudioMuteBtn.text = "Unmute Audio";
        else
            backgroundAudioMuteBtn.text = "Mute Audio";
        
        if (SoundManager.soundInstance.sfxMusicPlayer.mute)
            sfxAudoBtn.text = "Unmute SFX";
        else
            sfxAudoBtn.text = "Mute SFX";
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
