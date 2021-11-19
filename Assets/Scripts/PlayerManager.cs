using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject TapToStartText;

    public static bool isGameStarted;
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
    }

    void Update()
    {
        if(gameOver)
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
}
