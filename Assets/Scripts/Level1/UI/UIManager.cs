using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;
    public GameObject pauseBtn;

    [Header("Audios UI")]
    public Text backgroundAudioMuteBtn;
    public Text sfxAudoBtn;

    [SerializeField] private GameObject pausePanel;

    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (PlayerManager.isGameStarted)
        {
            /* takes the current score and adds it to the GUI text*/
            scoreText.text = $"Score: {PlayerManager.numberOfBusicuts}";
            pauseBtn.SetActive(true);
        }

        if (PlayerManager.gameOver)
        {
            scoreText.text = "";
            pauseBtn.SetActive(false);
            endScoreText.text = $"Your Score is: {EndScoreSys.LoadScore()}";
        }

        if (SoundManager.soundInstance.backgroundMusicPlayer.mute)
            backgroundAudioMuteBtn.text = "Unmute Audio";
        else
            backgroundAudioMuteBtn.text = "Mute Audio";

        if (SoundManager.soundInstance.sfxMusicPlayer.mute)
            sfxAudoBtn.text = "Unmute SFX";
        else
            sfxAudoBtn.text = "Mute SFX";
    }

    //UI manager

    public void Continue()
    {
        SceneManager.LoadScene("GiftPanel");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseBtn.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseBtn.SetActive(true);
        //enable the scripts again
    }

    //audio mute btns
    public void MuteBGAudio()
    {
        SoundManager.soundInstance.MuteBgAudio();
    }

    public void MuteSFXs()
    {
        SoundManager.soundInstance.MuteSFX();
    }
}
