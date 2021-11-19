using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject TapToStartText;

    public static bool isGameStarted;

    //for timmer
    public float timeRemaining = 180;
    public bool timmerIsRunning = false;
    public TextMeshProUGUI timmerText;

    [Header("for the GUI Text")]
    public TextMeshProUGUI timeOutTextBanner;

    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        timmerIsRunning = true;
    }

    void Update()
    {
        if (isGameStarted)
        {
            //timmer
            if (timmerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    Debug.Log("timeout");
                    timeRemaining = 0;
                    timmerIsRunning = false;

                    //logic which runs when time runs out.
                    gameOver = true;
                    CharCrontroller.boom = true;
                    StartCoroutine(GuiText());
                    StartCoroutine(GameOverFunc());
                }
                DisplayTime(timeRemaining);
            }
        }

        if (gameOver)
        {
            StartCoroutine(GameOverFunc());
        }

        if(SwipeManager.tap)
        {
            isGameStarted = true;
            TapToStartText.SetActive(false);
        }
    }

    IEnumerator GameOverFunc()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        yield return null;
    }

    private void DisplayTime(float timeToDisplay)
    {
        float mins = Mathf.FloorToInt(timeToDisplay / 60);
        float secs = Mathf.FloorToInt(timeToDisplay % 60);
        timmerText.text = string.Format("{0:00}:{1:00}", mins, secs);
    }

    //GUI saying time out
    IEnumerator GuiText()
    {
        timeOutTextBanner.text = "Time OUT";
        yield return new WaitForSeconds(.6f);
        timeOutTextBanner.text = "";
        yield return null;
    }
}
