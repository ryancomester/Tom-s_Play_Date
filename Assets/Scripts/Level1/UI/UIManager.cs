using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;
    public GameObject pauseBtn;
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
}
